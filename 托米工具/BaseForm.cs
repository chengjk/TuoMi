using System;
using System.Collections.Generic;

using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.ComponentModel;
using System.IO;
using 托米工具.tools;



namespace 托米工具
{
    public class BaseForm : Form
    {
        /// <summary>
        /// 字典表，要用到多个文档，先缓存起来。
        /// </summary>
        private ArrayList dicts;
        //private ILog log;
        protected string pathDirc;
        protected string pathDict;
        protected string pathWord;
        /// <summary>
        /// 是否反托米
        /// </summary>
        protected bool isReverse = false;
        /// <summary>
        /// 显示消息的地方
        /// </summary>
        protected BackgroundWorker bgw = new BackgroundWorker();
        public BaseForm()
        {
          //  log4net.Config.XmlConfigurator.Configure(new FileInfo("conf//log4net.xml"));
            //log = LogManager.GetLogger(this.GetType().ToString());
            LogHelper.SetConfig(new FileInfo("log4net.xml"));

           

            bgw.WorkerSupportsCancellation = true;
            bgw.DoWork += _doWork;
            bgw.WorkerReportsProgress = true;
            bgw.ProgressChanged += bgwChange;
            bgw.RunWorkerCompleted += _doWorkComplete;
        }

        private void bgwChange(Object sender,ProgressChangedEventArgs args)
        {
            string msg=args.UserState.ToString();
            updateProcessInfo(msg);
        }

        public virtual  void updateProcessInfo(string info)
        {
        }
        
        private void _doWork(object sender, EventArgs e)
        {

            dicts = DictUtil.read(pathDict);
            if (pathDirc != null && pathDirc != "")
            {
                DirectoryInfo di = new DirectoryInfo(pathDirc);
                ListFiles(di);
            }
            else
            {
                execute(pathWord);
            }
        }

       
        /// <summary>
        /// 递归执行所有文档
        /// </summary>
        /// <param name="info"></param>
        private void ListFiles(FileSystemInfo info)
        {
            if (!info.Exists) return;

            DirectoryInfo dir = info as DirectoryInfo;
            //不是目录 
            if (dir == null) return;

            FileSystemInfo[] files = dir.GetFileSystemInfos();
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = files[i] as FileInfo;
                //是文件 
                if (file != null)
                {
                    Console.WriteLine(file.FullName);
                    if (!file.Name.ToString().Contains("doc")) continue;
                    pathWord = file.FullName;
                    execute(pathWord);
                }
                //对于子目录，进行递归调用 
                else
                    ListFiles(files[i]);

            }
        }
        private void _doWorkComplete(object sender, EventArgs e)
        {
          //  updateProcessInfo("所有文档执行完毕！");
            MessageBox.Show("所有文档执行完毕！", "托米提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void execute(string pathWord)
        {
            Tuomi tm = new Tuomi();
            tm.updateProcessInfo += getTuomiMessage;
            //标记是否为反托米，用页面开关控制
            tm.reverse = isReverse;
            // MessageBox.Show(tm.reverse.ToString());
            try
            {
                tm.setWord07(pathWord);
                tm.setDicts(dicts);
                tm.replaceAllInDicts();
            }
            catch (Exception )
            {
                string msg = "打开文档出错，详细信息请参见日志。\n" + pathWord ;
                MessageBox.Show(msg,"打开失败",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            finally
            {
                tm.dispose();
            }
        }

        /// <summary>
        /// 接收Tuomi返回的消息。
        /// </summary>
        /// <param name="info"></param>
        private void getTuomiMessage(int percent,string info)
        {
            string name = pathWord;//.Substring(pathWord.LastIndexOf('\\'));
            string msg = "文档:" + name + "\n" + "替换:" + info;
            LogHelper.WriteLog(msg);
            bgw.ReportProgress(percent, msg);
        }
      
        /// <summary>
        /// 验证参数输入是否合法。
        /// 字典表路径必须，文档路径和目录路径有其一即可。
        /// </summary>
        /// <param name="showMsg">是否弹出错误消息</param>
        /// <returns></returns>
        protected bool validateParams(bool showMsg = false)
        {
            if (pathDict == null || pathDict == "")
            {
                if (showMsg) MessageBox.Show("字典表路径无效！请选择有效的字典表。", "托米提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (pathDirc == null || pathDirc == "")
            {
                if (pathWord == null || pathWord == "")
                {
                    if (showMsg) MessageBox.Show("文档路径无效！请选择有效的文档或目录。", "托米提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }
    }
}
