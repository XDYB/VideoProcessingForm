using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoProcessingForm
{
    public partial class Form1 : Form
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
            bltCapture.SetBalloonCaption(tbxCapture,"提示");
            bltCapture.SetBalloonText(tbxCapture,"请输入要抽取第几秒的缩略图");
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
                    }

                    listBox.Items.Clear();
                    list.Clear();

                    foreach (var file in ofd.FileNames)
                    {
                        listBox.Items.Add(file);
                        list.Add(file);
                    }

                    count = ofd.FileNames.Length;
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
                    }

                    DirectoryInfo dir = new DirectoryInfo(txtBoxOpen.Text);
                    FileInfo[] files = dir.GetFiles();
                    listBox.Items.Clear();
                    list.Clear();

                    foreach (var file in files)
                    {
                        listBox.Items.Add(file);
                        list.Add(txtBoxOpen.Text +"\\"+ file);
                    }

                    count = files.Length;
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
            string saveDir = "";//保存完整路径
            string isCover = "";

            if (txtBoxSave.Text == "")
            {
                MessageBox.Show("选择保存路径");
            }

            if (ckbCover.Checked)
            {
                isCover = "-y";
            }

            foreach (var item in list)
            {
                fileName = Path.GetFileName(item);
                string dir = txtBoxSave.Text.Split(new string[]{":\\"},StringSplitOptions.None)[1];
                if (dir == "")
                {
                    saveDir = txtBoxSave.Text + fileName;
                }
                else
                {
                    saveDir = txtBoxSave.Text + "\\" + fileName;
                }
                
            }
        }
    }
}
