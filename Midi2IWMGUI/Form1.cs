using NAudio.Midi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;
using static Midi2IWMGUI.XmlHelper;
using System.Xml;
using System.IO;
using System.Globalization;

namespace Midi2IWMGUI
{
    public partial class Form1 : Form
    {
        readonly double PITCH_MULTIPLE = Pow(2, 1d / 12d);
        const int DUCK_HIGHEST_PITCH = 73;
        const int DUCK_STANDARD = 61;
        public Form1()
        {
            InitializeComponent();
        }
        string midiFilename;
        MidiFile midiFile;
        List<Dictionary<string, object>> tracksConfig = new List<Dictionary<string, object>>();
        private void BtnSelectMidiFile_Click(object sender, EventArgs e)
        {
            if (openMidiDialog.ShowDialog() == DialogResult.OK)
            {
                midiFilename = openMidiDialog.FileName;
                TxtMidiFile.Text = midiFilename;

                midiFile = new MidiFile(midiFilename);
                PnlTracks.Enabled = true;

                LstTracks.Items.Clear();
                for (var i = 0; i < midiFile.Tracks; i++)
                {
                    LstTracks.Items.Add(i.ToString());
                    tracksConfig.Add(new Dictionary<string, object>());
                }
                TracksConfigSetDefault();
            }
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            // Start convert
            if (saveMidiDialog.ShowDialog() != DialogResult.OK)
                return;

            BtnConvert.Enabled = false;
            var filename = saveMidiDialog.FileName;
            var xml = new XmlDocument();
            var root = xml.CreateTag("sfm_map");
            var head = root.CreateTag(xml, "head");

            head.CreateTag(xml, "name", Path.GetFileNameWithoutExtension(filename));
            head.CreateTag(xml, "version", "59");
            head.CreateTag(xml, "tileset", "1");
            head.CreateTag(xml, "tileset2", "1");
            head.CreateTag(xml, "bg", "0");
            head.CreateTag(xml, "spikes", "1");
            head.CreateTag(xml, "width", "800");
            head.CreateTag(xml, "height", "608");
            head.CreateTag(xml, "colors", "5A0200000600000004000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
            head.CreateTag(xml, "scroll_mode", "0");
            head.CreateTag(xml, "music", "0");

            var objs = root.CreateTag(xml, "objects");

            for (var t = 0; t < midiFile.Tracks; t++)
            {
                var config = tracksConfig[t];
                if (!(bool)config["convert"])
                    continue;

                var pitchTable = GetPitchTable(DUCK_STANDARD);
                var speed = GetTickSecond(midiFile);
                var highest = GetHighestPitch(midiFile.Events[t]);
                var pitchFix = 0;

                for (var i = highest; i > DUCK_HIGHEST_PITCH; i -= 7)
                {
                    pitchFix -= 7;
                }

                foreach (var i in midiFile.Events[t])
                {
                    if (i is NoteOnEvent)
                    {
                        var obj = objs.CreateTag(xml, "object", "type", "8", "x", "16", "y", "16");

                        // Event: Create
                        var ev = obj.CreateTag(xml, "event", "eventIndex", "1");
                        var ac = ev.CreateTag(xml, "event", "eventIndex", "102");

                        var step = (int)(i.AbsoluteTime * speed * 50);
                        if (step <= 1) step = 1;
                        ac.CreateTag(xml, "param", "key", "frames", "val", step.ToString());
                        ac.CreateTag(xml, "param", "key", "timer_number", "val", "0");

                        // Event: Timer
                        ev = obj.CreateTag(xml, "event", "eventIndex", "2");
                        ev.CreateTag(xml, "param", "key", "timer_number", "val", "0");
                        ac = ev.CreateTag(xml, "event", "eventIndex", "103");
                        ac = ev.CreateTag(xml, "event", "eventIndex", "104");

                        var note = (NoteOnEvent)i;
                        var pitchIndex = note.NoteNumber + pitchFix < 0 ? 0 : note.NoteNumber + pitchFix;
                        var pitch = pitchTable[pitchIndex];
                        var pitchM = String.Format(CultureInfo.InvariantCulture, "{0,0:F}", pitch);
                        var pitchA = 0.00;
                        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                        pitchA = Double.Parse(pitchM);
                        if (pitchA >= 0.05)
                        {
                            ac.CreateTag(xml, "param", "key", "pitch", "val", pitchM.ToString());
                        }
                        else
                        {
                            ac.CreateTag(xml, "param", "key", "pitch", "val", "0.05");
                        }
                       // ac.CreateTag(xml, "param", "key", "pitch", "val", pitchM.ToString());
                        var sfx = (string)config["sfx"];
                        ac.CreateTag(xml, "param", "key", "sound", "val", GetSFXIndex(sfx));

                       ac.CreateTag(xml, "event", "eventIndex", "103");

                        // Trigger
                        obj.CreateTag(xml, "param", "key", "trigger_once", "val", "1");
                        obj.CreateTag(xml, "param", "key", "trigger_number", "val", "0");
                        obj.CreateTag(xml, "param", "key", "scale", "val", "1");
                        obj.CreateTag(xml, "param", "key", "visible", "val", "0");
                    }
                }
            }
            head.CreateTag(xml, "num_objects", objs.ChildNodes.Count.ToString());

            // Write to file
            if (File.Exists(filename))
                File.Delete(filename);

            var stream = File.Open(filename, FileMode.Create);
            var w = new XmlTextWriter(stream, System.Text.Encoding.Default)
            {
                Formatting = Formatting.None
            };
            xml.Save(w);
            stream.Close();
            BtnConvert.Enabled = true;
        }

        public double[] GetPitchTable(int standard)
        {
            var pitchTable = new double[128];
            var a = 1d;
            for (var i = standard; i < 128; i++)
            {
                pitchTable[i] = Round(a, 4);
                a *= PITCH_MULTIPLE;
            }
            a = 1d;
            for (var i = standard - 1; i >= 0; i--)
            {
                a /= PITCH_MULTIPLE;
                pitchTable[i] = Round(a, 4);
            }
            return pitchTable;
        }

        private void LstTracks_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = LstTracks.SelectedIndex;

            // Get note count
            var count = 0;
            foreach (var i in midiFile.Events[index])
            {
                if (i is NoteOnEvent)
                {
                    count++;
                }
            }
            LblNoteCount.Text = count.ToString();

            // Get highest & lowest pitch
            LblHighestPitch.Text = GetHighestPitch(midiFile.Events[index]).ToString();
            LblLowestPitch.Text = GetLowestPitch(midiFile.Events[index]).ToString();

            // Get length in frames
            var sec = GetTickSecond(midiFile);
            LblLengthInFrames.Text = Round(midiFile.Events[index].Last().AbsoluteTime * sec * 50).ToString();

            // Get config
            var config = tracksConfig[index];
            ChkConvert.Checked = (bool)config["convert"];
            CboSFX.Text = (string)config["sfx"];
        }

        private void TracksConfigSetDefault()
        {
            foreach (var i in tracksConfig)
            {
                i["convert"] = true;
                i["sfx"] = "Duck";
            }
        }

        private void ChkConvert_CheckedChanged(object sender, EventArgs e)
        {
            var index = LstTracks.SelectedIndex;
            var config = tracksConfig[index];
            config["convert"] = ChkConvert.Checked;
        }

        private void CboSFX_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = LstTracks.SelectedIndex;
            var config = tracksConfig[index];
            config["sfx"] = CboSFX.SelectedItem;
        }
        private double GetTickSecond(MidiFile midi)
        {
            double speed = 0;
            for (var t = 0; t < midiFile.Tracks; t++)
            {
                foreach (var i in midi.Events[t])
                {
                    if (i is TempoEvent)
                    {
                        var tempo = ((TempoEvent)i).MicrosecondsPerQuarterNote;
                        speed = tempo / midi.DeltaTicksPerQuarterNote; // μs
                        return speed / 1000000;
                    }
                }
            }
            return speed / 1000000;
        }

        private int GetHighestPitch(IList<MidiEvent> track)
        {
            var result = -1;
            foreach (var i in track)
            {
                if (i is NoteOnEvent)
                {
                    var note = (NoteOnEvent)i;
                    var pitch = note.NoteNumber;
                    if (result == -1)
                    {
                        result = pitch;
                    }
                    if (pitch > result)
                    {
                        result = pitch;
                    }
                }
            }
            return result;
        }

        private int GetLowestPitch(IList<MidiEvent> track)
        {
            var result = -1;
            foreach (var i in track)
            {
                if (i is NoteOnEvent)
                {
                    var note = (NoteOnEvent)i;
                    var pitch = note.NoteNumber;
                    if (result == -1)
                    {
                        result = pitch;
                    }
                    if (pitch < result)
                    {
                        result = pitch;
                    }
                }
            }
            return result;
        }
        private string GetSFXIndex(string name)
        {
            switch (name)
            {
                case "Duck": return "0";
                case "Bubble": return "2";
                case "Switch": return "3";
                case "Ring": return "4";
                case "Attention": return "5";
                case "Spring": return "6";
                case "Mike": return "7";
                case "OK": return "8";
                case "Break": return "9";
                case "Punch": return "10";
                case "Gun": return "11";
                case "Magic": return "12";
                case "Whistle": return "13";
                case "Button": return "14";
                case "Ninja": return "15";
                case "Hand": return "16";
                case "Drum": return "17";
                case "Piano": return "18";
                case "Bas-guitar": return "19";
                case "Kazoo": return "20";
                default: return "0";
            }
        }
    }
    static class XmlHelper
    {
        public static XmlElement CreateTag(this XmlElement element, XmlDocument xml, string tagName, string text)
        {
            var node = xml.CreateElement(tagName);
            node.InnerText = text;
            element.AppendChild(node);
            return node;
        }
        public static XmlElement CreateTag(this XmlElement element, XmlDocument xml, string tagName)
        {
            var node = xml.CreateElement(tagName);
            element.AppendChild(node);
            return node;
        }
        public static XmlElement CreateTag(this XmlElement element, XmlDocument xml, string tagName, params string[] attrs)
        {
            var node = xml.CreateElement(tagName);
            element.AppendChild(node);
            for (var i = 0; i < attrs.Length; i += 2)
            {
                node.SetAttribute(attrs[i], attrs[i + 1]);
            }
            return node;
        }
        public static XmlElement CreateTag(this XmlDocument xml, string tagName)
        {
            var node = xml.CreateElement(tagName);
            xml.AppendChild(node);
            return node;
        }
    }
}
