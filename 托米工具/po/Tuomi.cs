using System;
using System.Collections;

using System.Text;
using 托米工具.tools;
namespace 托米工具
{
    class Tuomi
    {
        /// <summary>
        /// 字典表
        /// </summary>
        private  ArrayList _dicts;

        private Word07 _wd ;

        /// <summary>
        /// 是否为反托米
        /// </summary>
        public bool reverse = false;

        public delegate void DelegateUpdateInfo(int percent,string info);

        /// <summary>
        /// 更新执行状态。
        /// 显示当前文档名称和正在替换的关键字。
        /// </summary>
        /// <param name="info"></param>
        public DelegateUpdateInfo updateProcessInfo;

        
       
        public Tuomi()
        {
           
        }
        /// <summary>
        /// 设置字典表
        /// </summary>
        /// <param name="dcts">字典表实例</param>
        public void setDicts(ArrayList dcts)
        {
            _dicts = dcts;
        }

        /// <summary>
        /// 设置字典表
        /// </summary>
        /// <param name="path">字典表全路径</param>
        public void setDicts(string path)
        {
            _dicts = DictUtil.read(path);
        }
        /// <summary>
        /// 指定一个07版的Word实例
        /// </summary>
        /// <param name="wd7">word实例</param>
        public void setWord07(Word07 wd7)
        {
            _wd = wd7;
        }
        /// <summary>
        /// 指定一个07版的Word实例
        /// </summary>
        /// <param name="file">全路径</param>
        public void setWord07(string file)
        {
            _wd = new Word07(file);
        }
        /// <summary>
        /// 返回当前word07实例。
        /// </summary>
        /// <returns></returns>
        public Word07 getWord07()
        {
            return _wd;
        }
        
        /// <summary>
        /// 在当前word中查找替换给定字典表中所有项。
        /// </summary>
        /// <returns></returns>
        public bool replaceAllInDicts() 
        {
           
            string strFrom;
            string strTo;
            if (_wd==null || _dicts == null)
            {
               
                return false;
            }
            try
            {
                //foreach (DictionaryEntry de in _dicts)
                //{
                //    strFrom = de.Key.ToString();
                //    strTo = de.Value.ToString();
                //    updateProcessInfo("From:" + strFrom + ",To:" + strTo);
                //    _wd.findRepleace(strFrom, strTo);
                //}
                int i = 0;
                for ( i = 0; i < _dicts.Count; i++)
                {
                    if (!reverse)
                    {
                        strFrom = _dicts[i].ToString().Split(',')[0];
                        strTo = _dicts[i].ToString().Split(',')[1];
                    }
                    else
                    {
                        strFrom = _dicts[i].ToString().Split(',')[1];
                        strTo = _dicts[i].ToString().Split(',')[0];
                    }
                    updateProcessInfo(i+1,"From:" + strFrom + ",To:" + strTo);
                    _wd.findRepleace(strFrom, strTo);
                }
                updateProcessInfo(i+1,"执行完毕！");
            }catch(Exception ex){
                throw ex;
               // return false;
            }
            return true;
        }
        /// <summary>
        /// 关闭当前文档
        /// </summary>
        public void closeDocument()
        {
            if (_wd == null) return;
            _wd.close();
            _wd = null;
        }

        /// <summary>
        /// 释放所有占用资源。
        /// 关闭当前文档，并退出word程序。
        /// </summary>
        public void  dispose()
        {
            if (_wd == null) return;
            _wd.close();
            _wd.quitApplication();
            _wd = null;
            _dicts = null;
        }
    }
}
