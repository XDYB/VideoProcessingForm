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
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.flv = new DevComponents.Editors.ComboItem();
            this.mp4 = new DevComponents.Editors.ComboItem();
            this.rmvb = new DevComponents.Editors.ComboItem();
            this.mp3 = new DevComponents.Editors.ComboItem();
            this.tbxCapture = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bltCapture = new DevComponents.DotNetBar.BalloonTip();
            this.btnStart = new DevComponents.DotNetBar.ButtonX();
            this.btnChangeFile = new DevComponents.DotNetBar.ButtonX();
            this.listBoxAdv1 = new DevComponents.DotNetBar.ListBoxAdv();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.checkBoxX1);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.comboBoxEx1);
            this.groupBox1.Controls.Add(this.tbxCapture);
            this.groupBox1.Location = new System.Drawing.Point(12, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能区";
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 15;
            this.comboBoxEx1.Items.AddRange(new object[] {
            this.flv,
            this.mp4,
            this.rmvb,
            this.mp3});
            this.comboBoxEx1.Location = new System.Drawing.Point(83, 20);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(71, 21);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.comboBoxEx1.TabIndex = 4;
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
            // tbxCapture
            // 
            this.tbxCapture.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbxCapture.Border.Class = "TextBoxBorder";
            this.tbxCapture.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxCapture.ButtonCustom.Tooltip = "";
            this.tbxCapture.ButtonCustom2.Tooltip = "";
            this.tbxCapture.DisabledBackColor = System.Drawing.Color.White;
            this.tbxCapture.ForeColor = System.Drawing.Color.Black;
            this.tbxCapture.Location = new System.Drawing.Point(262, 21);
            this.tbxCapture.Name = "tbxCapture";
            this.tbxCapture.PreventEnterBeep = true;
            this.tbxCapture.Size = new System.Drawing.Size(69, 21);
            this.tbxCapture.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStart.Location = new System.Drawing.Point(268, 359);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "开始";
            // 
            // btnChangeFile
            // 
            this.btnChangeFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChangeFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChangeFile.Location = new System.Drawing.Point(17, 12);
            this.btnChangeFile.Name = "btnChangeFile";
            this.btnChangeFile.Size = new System.Drawing.Size(75, 23);
            this.btnChangeFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChangeFile.TabIndex = 5;
            this.btnChangeFile.Text = "选择文件";
            // 
            // listBoxAdv1
            // 
            this.listBoxAdv1.AutoScroll = true;
            // 
            // 
            // 
            this.listBoxAdv1.BackgroundStyle.Class = "ListBoxAdv";
            this.listBoxAdv1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listBoxAdv1.CheckStateMember = null;
            this.listBoxAdv1.ContainerControlProcessDialogKey = true;
            this.listBoxAdv1.DragDropSupport = true;
            this.listBoxAdv1.Location = new System.Drawing.Point(18, 41);
            this.listBoxAdv1.Name = "listBoxAdv1";
            this.listBoxAdv1.Size = new System.Drawing.Size(338, 194);
            this.listBoxAdv1.TabIndex = 6;
            this.listBoxAdv1.Text = "listBoxAdv1";
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
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "是否覆盖相同文件：";
            // 
            // checkBoxX1
            // 
            // 
            // 
            // 
            this.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX1.CheckSignSize = new System.Drawing.Size(16, 16);
            this.checkBoxX1.Location = new System.Drawing.Point(126, 58);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Size = new System.Drawing.Size(16, 16);
            this.checkBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX1.TabIndex = 7;
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
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "转换格式：";
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
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "缩略图抓取：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 394);
            this.Controls.Add(this.listBoxAdv1);
            this.Controls.Add(this.btnChangeFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "视频转换工具";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxCapture;
        private DevComponents.Editors.ComboItem flv;
        private DevComponents.Editors.ComboItem mp4;
        private DevComponents.Editors.ComboItem rmvb;
        private DevComponents.Editors.ComboItem mp3;
        private DevComponents.DotNetBar.BalloonTip bltCapture;
        private DevComponents.DotNetBar.ButtonX btnStart;
        private DevComponents.DotNetBar.ButtonX btnChangeFile;
        private DevComponents.DotNetBar.ListBoxAdv listBoxAdv1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}

