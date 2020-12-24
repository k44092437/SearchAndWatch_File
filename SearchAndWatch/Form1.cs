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
            string sTmpFile = @"c:\tmpTest.txt";
            if (File.Exists(sTmpFile))
            {
                File.Delete(sTmpFile);
            }

            if (!System.IO.File.Exists(sTmpFile))
            {
                FileStream fs;
                fs = File.Create(sTmpFile);
                fs.Close();
            }

            if (!File.Exists(SearchTxtbox.Text.Trim()))
            {
                SearchTxtbox.Text = "File not exist!";
                SearchTxtbox.Focus();
                return false;
            }

            FileStream streamInput = System.IO.File.OpenRead(ChangeFileTxtbox.Text.Trim());
            FileStream streamOutput = System.IO.File.OpenWrite(sTmpFile);

            int iRowStartNums = 500;
            int iRowEndNums = 500;
            if (!string.IsNullOrEmpty(SearchStartNumTxtBox.Text.Trim())) {
                int.TryParse(SearchStartNumTxtBox.Text.Trim(), out iRowStartNums);
            }
            if (!string.IsNullOrEmpty(SearchEndNumTxtBox.Text.Trim()))
            {
                int.TryParse(SearchEndNumTxtBox.Text.Trim(), out iRowStartNums);
            }

            try
            {
                for (int i = 1; i <= iRowStartNums;)
                {
                    int result = streamInput.ReadByte();
                    if (result == 13)
                    {
                        i++;
                    }
                    if (result == -1)
                    {
                        break;
                    }
                    streamOutput.WriteByte((byte)result);
                }
            }
            finally
            {
                streamInput.Dispose();
                streamOutput.Dispose();
            }

            string sContent = ReaderFile(sTmpFile);
            CopyToClipboard(sContent);

            return true;
        }

        public static string ReaderFile(string path)
        {
            string fileData = string.Empty;
            try
            {   ///读取文件的内容    
                StreamReader reader = new StreamReader(path, Encoding.Default);
                fileData = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception ex)
            {
                 throw new Exception(ex.Message,ex);  
            }  ///抛出异常    
            return fileData;
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

        }
    }


    //private static string CreateMemoryMapFile(long ttargetRowNum)
    //{
    //    string line = string.Empty;
    //    using (FileStream fs = new FileStream(TXT_FILE_PATH, FileMode.Open, FileAccess.ReadWrite))
    //    {
    //        long targetRowNum = ttargetRowNum + 1;//目标行
    //        long curRowNum = 1;//当前行
    //        FILE_SIZE = fs.Length;
    //        using (MemoryMappedFile mmf = MemoryMappedFile.CreateFromFile(fs, "test", fs.Length, MemoryMappedFileAccess.ReadWrite, null, HandleInheritability.None, false))
    //        {
    //            long offset = 0;
    //            //int limit = 250;
    //            int limit = 200;
    //            try
    //            {
    //                StringBuilder sbDefineRowLine = new StringBuilder();
    //                do
    //                {
    //                    long remaining = fs.Length - offset;
    //                    using (MemoryMappedViewStream mmStream = mmf.CreateViewStream(offset, remaining > limit ? limit : remaining))
    //                    //using (MemoryMappedViewStream mmStream = mmf.CreateViewStream(offset, remaining))
    //                    {
    //                        offset += limit;
    //                        using (StreamReader sr = new StreamReader(mmStream))
    //                        {
    //                            //string ss = sr.ReadToEnd().ToString().Replace("\n", "囧").Replace(Environment.NewLine, "囧");
    //                            string ss = sr.ReadToEnd().ToString().Replace("\n", SPLIT_VARCHAR).Replace(Environment.NewLine, SPLIT_VARCHAR);
    //                            if (curRowNum <= targetRowNum)
    //                            {
    //                                if (curRowNum < targetRowNum)
    //                                {
    //                                    string s = sbDefineRowLine.ToString();
    //                                    int pos = s.LastIndexOf(SPLIT_CHAR);
    //                                    if (pos > 0)
    //                                        sbDefineRowLine.Remove(0, pos);

    //                                }
    //                                else
    //                                {
    //                                    line = sbDefineRowLine.ToString();
    //                                    return line;
    //                                }
    //                                if (ss.Contains(SPLIT_VARCHAR))
    //                                {
    //                                    curRowNum += GetNewLineNumsOfStr(ss);
    //                                    sbDefineRowLine.Append(ss);
    //                                }
    //                                else
    //                                {
    //                                    sbDefineRowLine.Append(ss);
    //                                }
    //                            }
    //                            //sbDefineRowLine.Append(ss);
    //                            //line = sbDefineRowLine.ToString();
    //                            //if (ss.Contains(Environment.NewLine))
    //                            //{
    //                            //    ++curRowNum;
    //                            //    //curRowNum++;
    //                            //    //curRowNum += GetNewLineNumsOfStr(ss);
    //                            //    //sbDefineRowLine.Append(ss);
    //                            //}
    //                            //if (curRowNum == targetRowNum)
    //                            //{
    //                            //    string s = "";
    //                            //}

    //                            sr.Dispose();
    //                        }

    //                        mmStream.Dispose();
    //                    }
    //                } while (offset < fs.Length);
    //            }
    //            catch (Exception e)
    //            {
    //                Console.WriteLine(e.Message);
    //            }
    //            return line;
    //        }
    //    }
    //}

    //private static long GetNewLineNumsOfStr(string s)
    //{
    //    string[] _lst = s.Split(SPLIT_CHAR);
    //    return _lst.Length - 1;
    //}
}
