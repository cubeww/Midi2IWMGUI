namespace Midi2IWMGUI
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSelectMidiFile = new System.Windows.Forms.Button();
            this.TxtMidiFile = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlTracks = new System.Windows.Forms.Panel();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.LblNoteCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ChkConvert = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboSFX = new System.Windows.Forms.ComboBox();
            this.LstTracks = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openMidiDialog = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.LblHighestPitch = new System.Windows.Forms.Label();
            this.LblLengthInFrames = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblLowestPitch = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.saveMidiDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.PnlTracks.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Midi File";
            // 
            // BtnSelectMidiFile
            // 
            this.BtnSelectMidiFile.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSelectMidiFile.Location = new System.Drawing.Point(60, 3);
            this.BtnSelectMidiFile.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSelectMidiFile.Name = "BtnSelectMidiFile";
            this.BtnSelectMidiFile.Size = new System.Drawing.Size(67, 26);
            this.BtnSelectMidiFile.TabIndex = 2;
            this.BtnSelectMidiFile.Text = "Select";
            this.BtnSelectMidiFile.UseVisualStyleBackColor = true;
            this.BtnSelectMidiFile.Click += new System.EventHandler(this.BtnSelectMidiFile_Click);
            // 
            // TxtMidiFile
            // 
            this.TxtMidiFile.Enabled = false;
            this.TxtMidiFile.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtMidiFile.Location = new System.Drawing.Point(0, 34);
            this.TxtMidiFile.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMidiFile.Name = "TxtMidiFile";
            this.TxtMidiFile.Size = new System.Drawing.Size(368, 23);
            this.TxtMidiFile.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtMidiFile);
            this.panel1.Controls.Add(this.BtnSelectMidiFile);
            this.panel1.Location = new System.Drawing.Point(13, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 74);
            this.panel1.TabIndex = 3;
            // 
            // PnlTracks
            // 
            this.PnlTracks.Controls.Add(this.LblLowestPitch);
            this.PnlTracks.Controls.Add(this.label10);
            this.PnlTracks.Controls.Add(this.LblLengthInFrames);
            this.PnlTracks.Controls.Add(this.label7);
            this.PnlTracks.Controls.Add(this.LblHighestPitch);
            this.PnlTracks.Controls.Add(this.label5);
            this.PnlTracks.Controls.Add(this.BtnConvert);
            this.PnlTracks.Controls.Add(this.LblNoteCount);
            this.PnlTracks.Controls.Add(this.label4);
            this.PnlTracks.Controls.Add(this.ChkConvert);
            this.PnlTracks.Controls.Add(this.label3);
            this.PnlTracks.Controls.Add(this.CboSFX);
            this.PnlTracks.Controls.Add(this.LstTracks);
            this.PnlTracks.Controls.Add(this.label2);
            this.PnlTracks.Enabled = false;
            this.PnlTracks.Location = new System.Drawing.Point(13, 89);
            this.PnlTracks.Margin = new System.Windows.Forms.Padding(2);
            this.PnlTracks.Name = "PnlTracks";
            this.PnlTracks.Size = new System.Drawing.Size(367, 223);
            this.PnlTracks.TabIndex = 4;
            // 
            // BtnConvert
            // 
            this.BtnConvert.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnConvert.Location = new System.Drawing.Point(-1, 171);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(368, 49);
            this.BtnConvert.TabIndex = 5;
            this.BtnConvert.Text = "Convert";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // LblNoteCount
            // 
            this.LblNoteCount.AutoSize = true;
            this.LblNoteCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblNoteCount.Location = new System.Drawing.Point(186, 26);
            this.LblNoteCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNoteCount.Name = "LblNoteCount";
            this.LblNoteCount.Size = new System.Drawing.Size(15, 20);
            this.LblNoteCount.TabIndex = 9;
            this.LblNoteCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(104, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Note Count:";
            // 
            // ChkConvert
            // 
            this.ChkConvert.AutoSize = true;
            this.ChkConvert.Checked = true;
            this.ChkConvert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkConvert.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChkConvert.Location = new System.Drawing.Point(235, 26);
            this.ChkConvert.Margin = new System.Windows.Forms.Padding(2);
            this.ChkConvert.Name = "ChkConvert";
            this.ChkConvert.Size = new System.Drawing.Size(72, 21);
            this.ChkConvert.TabIndex = 7;
            this.ChkConvert.Text = "Convert";
            this.ChkConvert.UseVisualStyleBackColor = true;
            this.ChkConvert.CheckedChanged += new System.EventHandler(this.ChkConvert_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(233, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "SFX";
            // 
            // CboSFX
            // 
            this.CboSFX.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CboSFX.FormattingEnabled = true;
            this.CboSFX.Items.AddRange(new object[] {
            "OK",
            "Switch",
            "Break",
            "Magic",
            "Punch",
            "Mike",
            "Spring",
            "Duck",
            "Attention",
            "Ring",
            "Bubble",
            "Gun",
            "Whistle",
            "Button",
            "Ninja",
            "Hand",
            "Drum",
            "Piano",
            "Bas-Guitar",
            "Kazoo"});
            this.CboSFX.Location = new System.Drawing.Point(264, 54);
            this.CboSFX.Margin = new System.Windows.Forms.Padding(2);
            this.CboSFX.Name = "CboSFX";
            this.CboSFX.Size = new System.Drawing.Size(92, 25);
            this.CboSFX.TabIndex = 5;
            this.CboSFX.Text = "Duck";
            this.CboSFX.SelectedIndexChanged += new System.EventHandler(this.CboSFX_SelectedIndexChanged);
            // 
            // LstTracks
            // 
            this.LstTracks.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LstTracks.FormattingEnabled = true;
            this.LstTracks.ItemHeight = 20; // IMPORTANT
            this.LstTracks.Location = new System.Drawing.Point(3, 26);
            this.LstTracks.Margin = new System.Windows.Forms.Padding(2);
            this.LstTracks.Name = "LstTracks";
            this.LstTracks.Size = new System.Drawing.Size(97, 140);
            this.LstTracks.TabIndex = 4;
            this.LstTracks.SelectedIndexChanged += new System.EventHandler(this.LstTracks_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(2, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tracks";
            // 
            // openMidiDialog
            // 
            this.openMidiDialog.Filter = "Midi File|*.mid;*.midi|All Files|*.*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(104, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Highest Pitch:";
            // 
            // LblHighestPitch
            // 
            this.LblHighestPitch.AutoSize = true;
            this.LblHighestPitch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblHighestPitch.Location = new System.Drawing.Point(186, 54);
            this.LblHighestPitch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblHighestPitch.Name = "LblHighestPitch";
            this.LblHighestPitch.Size = new System.Drawing.Size(15, 20);
            this.LblHighestPitch.TabIndex = 11;
            this.LblHighestPitch.Text = "0";
            // 
            // LblLengthInFrames
            // 
            this.LblLengthInFrames.AutoSize = true;
            this.LblLengthInFrames.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblLengthInFrames.Location = new System.Drawing.Point(213, 108);
            this.LblLengthInFrames.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLengthInFrames.Name = "LblLengthInFrames";
            this.LblLengthInFrames.Size = new System.Drawing.Size(15, 20);
            this.LblLengthInFrames.TabIndex = 13;
            this.LblLengthInFrames.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(104, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Length In Frames:";
            // 
            // LblLowestPitch
            // 
            this.LblLowestPitch.AutoSize = true;
            this.LblLowestPitch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblLowestPitch.Location = new System.Drawing.Point(186, 81);
            this.LblLowestPitch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLowestPitch.Name = "LblLowestPitch";
            this.LblLowestPitch.Size = new System.Drawing.Size(15, 8);
            this.LblLowestPitch.TabIndex = 17;
            this.LblLowestPitch.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(104, 81);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Lowest Pitch:";
            // 
            // saveMidiDialog
            // 
            this.saveMidiDialog.Filter = "Map File|*.map|All Files|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 315);
            this.Controls.Add(this.PnlTracks);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Midi2IWM";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlTracks.ResumeLayout(false);
            this.PnlTracks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSelectMidiFile;
        private System.Windows.Forms.TextBox TxtMidiFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlTracks;
        private System.Windows.Forms.ListBox LstTracks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ChkConvert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboSFX;
        private System.Windows.Forms.OpenFileDialog openMidiDialog;
        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.Label LblNoteCount;
        private System.Windows.Forms.Label LblLowestPitch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblLengthInFrames;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblHighestPitch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog saveMidiDialog;
    }
}

