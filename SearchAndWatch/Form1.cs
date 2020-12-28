using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace SearchAndWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ReadBigFile()
        {
            //string sTmpFile = @"c:\tmpTest.txt";
            //if (File.Exists(sTmpFile))
            //{
            //    File.Delete(sTmpFile);
            //}

            //if (!System.IO.File.Exists(sTmpFile))
            //{
            //    FileStream fs;
            //    fs = File.Create(sTmpFile);
            //    fs.Close();
            //}

            if (!File.Exists(ChangeFileTxtbox.Text.Trim()))
            {
                output("文件未找到。");
                ChangeFileTxtbox.Focus();
                return false;
            }

            //FileStream streamOutput = System.IO.File.OpenWrite(sTmpFile);

            int iRowStartNums = 500;
            int iRowEndNums = 500;
            if (!string.IsNullOrEmpty(SearchStartNumTxtBox.Text.Trim())) {
                int.TryParse(SearchStartNumTxtBox.Text.Trim(), out iRowStartNums);
            }
            if (!string.IsNullOrEmpty(SearchEndNumTxtBox.Text.Trim()))
            {
                int.TryParse(SearchEndNumTxtBox.Text.Trim(), out iRowEndNums);
            }

            FileStream fsRead;
            //获取文件路径
            string filePath = ChangeFileTxtbox.Text.Trim().ToString();
            string strFile;
            string strTxt = SearchTxtbox.Text.Trim().ToString();
            //用FileStream文件流打开文件
            try
            {
                fsRead = new FileStream(@filePath, FileMode.Open);
            }
            catch (Exception)
            {

                throw;
            }

            //还没有读取的文件内容长度
            long leftLength = fsRead.Length;
            //创建接收文件内容的字节数组
            byte[] buffer = new byte[(iRowStartNums+ iRowEndNums)*2];
            //每次读取的最大字节数
            int maxLength = buffer.Length;
            //每次实际返回的字节数长度
            int num = 0;
            //文件开始读取的位置
            int fileStart = 0;

            while (leftLength > 0)
            {
                //设置文件流的读取位置
                fsRead.Position = fileStart;
                if (leftLength < maxLength)
                {
                    num = fsRead.Read(buffer, 0, Convert.ToInt32(leftLength));
                }
                else
                {
                    num = fsRead.Read(buffer, 0, maxLength);
                }
                if (num == 0)
                {
                    break;
                }
                fileStart += num;
                leftLength -= num;
                strFile = Encoding.UTF8.GetString(buffer);
                try
                {
                    if (strFile.ToString().Contains(strTxt.ToString()))
                    {
                        int num1 = strFile.IndexOf(strTxt.ToString());
                        int num2 = num1 - iRowStartNums;
                        if (num2 > 0)
                        {
                            output(strFile.Substring(num2, num2 + iRowStartNums + iRowEndNums).ToString());
                        }
                        else
                        {
                            output(strFile.Substring(0, num1 + iRowEndNums).ToString());
                        }
                    }
                }
                catch (Exception ex)
                {

                    output(ex.ToString());
                }
                
            }
            output("end of line");

            return true;
        }

        private void CopyToClipboard(string sSource)
        {
            Clipboard.Clear();
            if (!string.IsNullOrEmpty(sSource))
            {
                Clipboard.SetText(sSource);
            }
        }

        private void ChangeFileTxtbox_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dialog.FileName;
                ChangeFileTxtbox.Text = file.ToString();
            }
        }

        delegate void SafeSetText(string strMsg);

        private void output(string strMsg)
        {
            SafeSetText objSet = delegate (string str)
            {
                ShowTxt.AppendText(str + "\r\n");
            };
            ShowTxt.Invoke(objSet, new object[] { strMsg });
        }

        private void AllSearchBtn_Click(object sender, EventArgs e)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Thread childThread = new Thread(childref);
            childThread.Start();
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {

        }

        private void DownBtn_Click(object sender, EventArgs e)
        {

        }

        public void CallToChildThread()
        {
            ReadBigFile();
        }
    }
}
