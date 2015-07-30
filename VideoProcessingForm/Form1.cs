using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoProcessingForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            setTip();
        }

        /// <summary>
        /// 信息提示
        /// </summary>
        private void setTip()
        {
            bltCapture.SetBalloonCaption(tbxCapture,"提示");
            bltCapture.SetBalloonText(tbxCapture,"请输入要抓取第几秒的缩略图");
        }
    }
}
