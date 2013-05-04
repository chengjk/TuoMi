using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using 托米工具.tools;
using System.IO;
namespace 托米工具
{
    public partial class Form3 : BaseForm
    {
        public Form3()
        {
            InitializeComponent();
            this.isReverse = chkReverse.CheckState == CheckState.Checked;
            
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
           // pathDict=@"C:\Users\Administrator\Documents\Visual Studio 2010\Projects\托米工具\托米工具\Dicts\FHJ.txt";
            //pathWord = @"E://Test//1.docx";
           
            if (bgw.IsBusy)
            {
                MessageBox.Show(RandomTips.getExecutingTip(), "托米提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!validateParams(true)) return;
            bgw.RunWorkerAsync();
        }
       
        private void grpDict_DragEnter(object sender, DragEventArgs e)
        {
            //判断是否目前拖动的数据是字符串，如果是，则拖动符串对目的组件进行拷贝
            String Path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
           
            if (e.Data.GetDataPresent(DataFormats.FileDrop)&&Path.IndexOf(".txt") != -1)
            {
                 e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void grpDict_DragDrop(object sender, DragEventArgs e)
        {
            String Path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            FileInfo fi = new FileInfo(Path);
            String str = fi.Extension.ToUpper();
           
            
            this.pathDict = Path;
            grpDict.Text = Path.Substring(Path.LastIndexOf('\\'));
            grpDict.BackgroundImage = Properties.Resources.txt1;
        }

        private void grpDir_DragEnter(object sender, DragEventArgs e)
        {
            String Path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            FileInfo fi = new FileInfo(Path);
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                if (fi .Extension!="")
                {
                    if (fi.Extension.ToLower().Contains("doc")) //*.doc||*.docx
                    {
                        e.Effect = DragDropEffects.Move;
                    }
                }
                else
                {
                    e.Effect = DragDropEffects.Move;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void grpDir_DragDrop(object sender, DragEventArgs e)
        {
            String Path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            FileInfo fi = new FileInfo(Path);
            if (fi.Extension=="")
            {
                pathDirc = Path;
            }
            else
            {
                pathWord = Path;
            }

            grpDir.BackgroundImage = Properties.Resources.folder1;
            grpDir.Text = Path.Substring(Path.LastIndexOf('\\'));
        }

        private void 退出QToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bgw.IsBusy)
            {
                DialogResult result = MessageBox.Show("程序正在运行，是否要退出？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    bgw.CancelAsync();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void 新建字典表CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "    字典表书写格式：strFrom，strTo。将文档中所有strFrom替换为strTo。多个对应关系时换行处理，每行一个对应关系，若格式不正确则跳过该字符，如果书写多个对应关系则只读取第一个，其余的无效。"
                        + "字典表内容自定义，目的是让其他人看不懂。"
                        + "例如，定义了三个对应关系:\n"
                        + "军事，JUNSHI\n"
                        + "危险，WEIXIAN\n"
                        + "单位，DanWei\n"
                        + "将以上内容保存成一个.txt文件就是一个字典文件。";

            MessageBox.Show(msg, "新建字典表提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 如何使用UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "拖动一个文件夹或一个Word文档到“目录”处，拖动一个字典表到“字典表”处，按需求选择“是否反托米”，点击“Go！”执行。";
            MessageBox.Show(msg, "如何使用",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void 选择字典ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "请使用拖动方式来完成！";
            MessageBox.Show(msg,"托米提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void 选择目录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "请使用拖动方式来完成！";
            MessageBox.Show(msg,"托米提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
