namespace VideoProcessingForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.ckbCover = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.comBoxChangeType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.flv = new DevComponents.Editors.ComboItem();
            this.mp4 = new DevComponents.Editors.ComboItem();
            this.rmvb = new DevComponents.Editors.ComboItem();
            this.mp3 = new DevComponents.Editors.ComboItem();
            this.bltCapture = new DevComponents.DotNetBar.BalloonTip();
            this.btnStart = new DevComponents.DotNetBar.ButtonX();
            this.listBox = new DevComponents.DotNetBar.ListBoxAdv();
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.lbCount = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtBoxSave = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSavaDir = new DevComponents.DotNetBar.ButtonX();
            this.txtBoxOpen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.comBoxChangeFile = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.选择 = new DevComponents.Editors.ComboItem();
            this.文件 = new DevComponents.Editors.ComboItem();
            this.文件夹 = new DevComponents.Editors.ComboItem();
            this.jpg = new DevComponents.Editors.ComboItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeEdit1);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.ckbCover);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.comBoxChangeType);
            this.groupBox1.Location = new System.Drawing.Point(12, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 86);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能区";
            // 
            // timeEdit1
            // 
            this.timeEdit1.EditValue = new System.DateTime(2015, 8, 1, 0, 0, 0, 0);
            this.timeEdit1.Location = new System.Drawing.Point(254, 20);
            this.timeEdit1.Name = "timeEdit1";
            this.timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit1.Size = new System.Drawing.Size(75, 20);
            this.timeEdit1.TabIndex = 3;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(179, 21);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(80, 23);
            this.labelX3.TabIndex = 24;
            this.labelX3.Text = "缩略图抽取：";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 21);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(68, 23);
            this.labelX2.TabIndex = 23;
            this.labelX2.Text = "转换格式：";
            // 
            // ckbCover
            // 
            // 
            // 
            // 
            this.ckbCover.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ckbCover.CheckSignSize = new System.Drawing.Size(16, 16);
            this.ckbCover.Location = new System.Drawing.Point(126, 58);
            this.ckbCover.Name = "ckbCover";
            this.ckbCover.Size = new System.Drawing.Size(16, 16);
            this.ckbCover.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ckbCover.TabIndex = 4;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 57);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(118, 23);
            this.labelX1.TabIndex = 25;
            this.labelX1.Text = "是否覆盖相同文件：";
            // 
            // comBoxChangeType
            // 
            this.comBoxChangeType.DisplayMember = "Text";
            this.comBoxChangeType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBoxChangeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxChangeType.FormattingEnabled = true;
            this.comBoxChangeType.ItemHeight = 15;
            this.comBoxChangeType.Items.AddRange(new object[] {
            this.flv,
            this.mp4,
            this.rmvb,
            this.mp3,
            this.jpg});
            this.comBoxChangeType.Location = new System.Drawing.Point(83, 20);
            this.comBoxChangeType.Name = "comBoxChangeType";
            this.comBoxChangeType.Size = new System.Drawing.Size(71, 21);
            this.comBoxChangeType.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.comBoxChangeType.TabIndex = 2;
            // 
            // flv
            // 
            this.flv.Text = "flv";
            this.flv.Value = "flv";
            // 
            // mp4
            // 
            this.mp4.Text = "mp4";
            this.mp4.Value = "mp4";
            // 
            // rmvb
            // 
            this.rmvb.Text = "rmvb";
            this.rmvb.Value = "rmvb";
            // 
            // mp3
            // 
            this.mp3.Text = "mp3";
            this.mp3.Value = "mp3";
            // 
            // btnStart
            // 
            this.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStart.Location = new System.Drawing.Point(274, 413);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "开始";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // listBox
            // 
            this.listBox.AutoScroll = true;
            // 
            // 
            // 
            this.listBox.BackgroundStyle.Class = "ListBoxAdv";
            this.listBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listBox.ContainerControlProcessDialogKey = true;
            this.listBox.DragDropSupport = true;
            this.listBox.Location = new System.Drawing.Point(12, 46);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(344, 172);
            this.listBox.TabIndex = 21;
            // 
            // progressBarX1
            // 
            // 
            // 
            // 
            this.progressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX1.Location = new System.Drawing.Point(120, 372);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(235, 23);
            this.progressBarX1.TabIndex = 30;
            this.progressBarX1.Text = "progressBarX1";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(17, 372);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(54, 23);
            this.labelX4.TabIndex = 28;
            this.labelX4.Text = "正在处理";
            // 
            // lbCount
            // 
            // 
            // 
            // 
            this.lbCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbCount.Location = new System.Drawing.Point(67, 372);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(48, 23);
            this.lbCount.TabIndex = 29;
            this.lbCount.Text = "(0\\0)";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(17, 335);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(66, 23);
            this.labelX6.TabIndex = 26;
            this.labelX6.Text = "保存路径：";
            // 
            // txtBoxSave
            // 
            this.txtBoxSave.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtBoxSave.Border.Class = "TextBoxBorder";
            this.txtBoxSave.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBoxSave.ButtonCustom.Tooltip = "";
            this.txtBoxSave.ButtonCustom2.Tooltip = "";
            this.txtBoxSave.DisabledBackColor = System.Drawing.Color.White;
            this.txtBoxSave.ForeColor = System.Drawing.Color.Black;
            this.txtBoxSave.Location = new System.Drawing.Point(79, 335);
            this.txtBoxSave.Name = "txtBoxSave";
            this.txtBoxSave.PreventEnterBeep = true;
            this.txtBoxSave.ReadOnly = true;
            this.txtBoxSave.Size = new System.Drawing.Size(216, 21);
            this.txtBoxSave.TabIndex = 27;
            // 
            // btnSavaDir
            // 
            this.btnSavaDir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSavaDir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSavaDir.Location = new System.Drawing.Point(301, 333);
            this.btnSavaDir.Name = "btnSavaDir";
            this.btnSavaDir.Size = new System.Drawing.Size(54, 23);
            this.btnSavaDir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSavaDir.TabIndex = 5;
            this.btnSavaDir.Text = "选择";
            this.btnSavaDir.Click += new System.EventHandler(this.btnSavaDir_Click);
            // 
            // txtBoxOpen
            // 
            this.txtBoxOpen.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtBoxOpen.Border.Class = "TextBoxBorder";
            this.txtBoxOpen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBoxOpen.ButtonCustom.Tooltip = "";
            this.txtBoxOpen.ButtonCustom2.Tooltip = "";
            this.txtBoxOpen.DisabledBackColor = System.Drawing.Color.White;
            this.txtBoxOpen.ForeColor = System.Drawing.Color.Black;
            this.txtBoxOpen.Location = new System.Drawing.Point(12, 14);
            this.txtBoxOpen.Name = "txtBoxOpen";
            this.txtBoxOpen.PreventEnterBeep = true;
            this.txtBoxOpen.ReadOnly = true;
            this.txtBoxOpen.Size = new System.Drawing.Size(271, 21);
            this.txtBoxOpen.TabIndex = 20;
            // 
            // comBoxChangeFile
            // 
            this.comBoxChangeFile.DisplayMember = "Text";
            this.comBoxChangeFile.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBoxChangeFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxChangeFile.FormattingEnabled = true;
            this.comBoxChangeFile.ItemHeight = 15;
            this.comBoxChangeFile.Items.AddRange(new object[] {
            this.选择,
            this.文件,
            this.文件夹});
            this.comBoxChangeFile.Location = new System.Drawing.Point(291, 14);
            this.comBoxChangeFile.Name = "comBoxChangeFile";
            this.comBoxChangeFile.Size = new System.Drawing.Size(65, 21);
            this.comBoxChangeFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comBoxChangeFile.TabIndex = 1;
            this.comBoxChangeFile.SelectedIndexChanged += new System.EventHandler(this.comBoxChangeFile_SelectedIndexChanged);
            // 
            // 选择
            // 
            this.选择.Text = "选择";
            this.选择.Value = "0";
            // 
            // 文件
            // 
            this.文件.Text = "文件";
            this.文件.Value = "1";
            // 
            // 文件夹
            // 
            this.文件夹.Text = "文件夹";
            this.文件夹.Value = "2";
            // 
            // jpg
            // 
            this.jpg.Text = "jpg";
            this.jpg.Value = "jpg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(368, 451);
            this.Controls.Add(this.comBoxChangeFile);
            this.Controls.Add(this.txtBoxOpen);
            this.Controls.Add(this.btnSavaDir);
            this.Controls.Add(this.txtBoxSave);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.progressBarX1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "视频转换工具";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comBoxChangeType;
        private DevComponents.Editors.ComboItem flv;
        private DevComponents.Editors.ComboItem mp4;
        private DevComponents.Editors.ComboItem rmvb;
        private DevComponents.Editors.ComboItem mp3;
        private DevComponents.DotNetBar.BalloonTip bltCapture;
        private DevComponents.DotNetBar.ButtonX btnStart;
        private DevComponents.DotNetBar.ListBoxAdv listBox;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckbCover;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX lbCount;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBoxSave;
        private DevComponents.DotNetBar.ButtonX btnSavaDir;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBoxOpen;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comBoxChangeFile;
        private DevComponents.Editors.ComboItem 文件;
        private DevComponents.Editors.ComboItem 文件夹;
        private DevComponents.Editors.ComboItem 选择;
        private DevExpress.XtraEditors.TimeEdit timeEdit1;
        private DevComponents.Editors.ComboItem jpg;
    }
}

