using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoProcessingForm
{
    public partial class Form1 : DevComponents.DotNetBar.Metro.MetroForm
    {
        public int count;
        List<String> list = new List<String>();//用于存放文件的完整路径

        public Form1()
        {
            InitializeComponent();

            comBoxChangeFile.SelectedIndex = 0;
            comBoxChangeType.SelectedIndex = 1;//转换格式默认选择第二个 mp4
            setTip();
        }

        /// <summary>
        /// 信息提示
        /// </summary>
        private void setTip()
        {
            bltCapture.SetBalloonCaption(timeEdit1, "提示");
            bltCapture.SetBalloonText(timeEdit1, "请输入要抽取第几秒的缩略图");
        }

        /// <summary>
        /// 选择文件夹或文件夹中的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comBoxChangeFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comBoxChangeFile.SelectedIndex != 0)
            {
                if (comBoxChangeFile.SelectedIndex == 1)
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Title = "选择文件";
                    ofd.Multiselect = true;

                    if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        txtBoxOpen.Text = Path.GetDirectoryName(ofd.FileName);
                        listBox.Items.Clear();
                        list.Clear();

                        foreach (var file in ofd.FileNames)
                        {
                            listBox.Items.Add(file);
                            list.Add(file);
                        }

                        count = ofd.FileNames.Length;
                    }

                }
                else
                {
                    FolderBrowserDialog fbd = new FolderBrowserDialog();
                    fbd.Description = "选择文件夹";
                    fbd.RootFolder = Environment.SpecialFolder.MyComputer;
                    fbd.ShowNewFolderButton = false;
                    fbd.SelectedPath = txtBoxOpen.Text;

                    if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        txtBoxOpen.Text = fbd.SelectedPath;
                        DirectoryInfo dir = new DirectoryInfo(txtBoxOpen.Text);
                        FileInfo[] files = dir.GetFiles();
                        listBox.Items.Clear();
                        list.Clear();

                        foreach (var file in files)
                        {
                            listBox.Items.Add(file);
                            list.Add(txtBoxOpen.Text + "\\" + file);
                        }

                        count = files.Length;
                    }

                }

                lbCount.Text = "(0/" + count + ")";//文件个数
            }
        }

        /// <summary>
        /// 保存目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSavaDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "选择保存目录";
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd.SelectedPath = txtBoxSave.Text;
            fbd.ShowNewFolderButton = true;

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtBoxSave.Text = fbd.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string fileName = "";//文件名
            string newDir = "";//新文件的完整路径
            string isCover = "";//是否覆盖同名文件
            string timeStr = "";//时间点
            string typeStr = "";   //转换类型

            if (timeEdit1.Text.Length == 7)
            {
                timeStr = "0" + timeEdit1.Text;
            }
            else 
            {
                timeStr = timeEdit1.Text;
            }

            if (txtBoxSave.Text == "")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("选择保存路径","提示");
                //MessageBox.Show("选择保存路径");
                return;
            }

            if (ckbCover.Checked)
            {
                isCover = "-y";
            }

            //得到选中下拉的值
            typeStr = comBoxChangeType.SelectedItem.ToString();

            foreach (var oldDir in list)
            {
                fileName = Path.GetFileName(oldDir);
                string dir = txtBoxSave.Text.Split(new string[]{":\\"},StringSplitOptions.None)[1];

                if (dir == "")
                {
                    newDir = txtBoxSave.Text + fileName + "." + typeStr;
                }
                else
                {
                    newDir = txtBoxSave.Text + "\\" + fileName + "." + typeStr;
                }

                lbCount.Text = "("+Convert.ToInt32(list.IndexOf(oldDir)+1)+"/" + count + ")";//正在处理第几个文件
                ExcuteProcess("../../ffmpeg.exe", oldDir, newDir, timeStr, isCover);
            }
        }

        /// <summary>
        /// 调用FFmpeg
        /// </summary>
        /// <param name="exe">要调用的exe文件</param>
        /// <param name="oldFile">源文件</param>
        /// <param name="newFile">新文件</param>
        /// <param name="time">要在第几秒抽取缩略图</param>
        /// <param name="isCover">是否覆盖同名文件</param>
        private void ExcuteProcess(string exe, string oldFile, string newFile, string time, string isCover)
        {
            using (var p = new Process())
            {
                p.StartInfo.FileName = exe;
                p.StartInfo.Arguments = "-i \"" + oldFile + "\" " + isCover + " -ss " + time + " \"" +  newFile + "\"";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardError = false;
                p.StartInfo.RedirectStandardOutput = false;

                p.Start();
                p.WaitForExit();//这句会使界面卡住，无法拖动
                p.Close();
            }
        }
    }
}
