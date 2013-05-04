using System;
using System.Collections.Generic;

using System.Text;
using Microsoft.Office.Interop.Word;
using System.IO;


namespace 托米工具.tools
{
    class Word07
    {
        Application app = new Application();
        object nullObj = System.Reflection.Missing.Value;
        

        Document doc;

        private FileInfo fi;

        public Word07(string file)
        {
            fi= new FileInfo(file);
            try
            {
                open(file);
            }
            catch (Exception ex)
            {
                string msg = "打开文档" + file + "出错!";
                LogHelper.WriteLog(msg,ex);
                throw ex;
            }
        }

        /// <summary>
        /// 名称
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return fi.Name;
        }

        /// <summary>
        /// 打开制定文件，作为当前文档。
        /// </summary>
        /// <param name="fName"></param>
        private  void open(string fName)
        {
            object file;
            try
            {
                file = fName;
                doc = app.Documents.Open(
                    ref file,
                    ref nullObj,
                    ref nullObj,
                    ref nullObj,
                    ref nullObj,
                    ref nullObj,
                    ref nullObj,
                    ref nullObj,
                    ref nullObj,
                    ref nullObj,
                    ref nullObj,
                    ref nullObj,
                    ref nullObj,
                    ref nullObj,
                    ref nullObj,
                    ref nullObj
                    );
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        /// <summary>
        /// 查找替换当前文档
        /// </summary>
        /// <param name="from">原始字符串</param>
        /// <param name="to">目标字符串</param>
        /// <returns></returns>
        public bool findRepleace(string from ,string to){
            bool flag=false;
            try
            {
                object objFrom = from;
                object objTo = to;

                object Y = true;
                object N = System.Reflection.Missing.Value;
                object replaceAll = WdReplace.wdReplaceAll;
                object wrap = WdFindWrap.wdFindContinue;

                app.Selection.Find.ClearFormatting();
                app.Selection.Find.Text = from;
                app.Selection.Find.Replacement.ClearFormatting();
                app.Selection.Find.Replacement.Text = to;
                //这两个都行
                flag=doc.Content.Find.Execute2007(
                //flag = app.Selection.Find.Execute2007(
                    ref objFrom,//ref Object FindText,
	                ref N,//ref Object MatchCase,
	                ref N,//ref Object MatchWholeWord,
	                ref N,//ref Object MatchWildcards,
	                ref N,//ref Object MatchSoundsLike,
	                ref N,//ref Object MatchAllWordForms,
	                ref Y,//ref Object Forward,
                    ref wrap,//ref Object Wrap,
	                ref N,//ref Object Format,
	                ref objTo,//ref Object ReplaceWith,
	                ref replaceAll,//ref Object Replace,
	                ref N,//ref Object MatchKashida,
	                ref N,//ref Object MatchDiacritics,
	                ref N,//ref Object MatchAlefHamza,
	                ref N,//ref Object MatchControl,
	                ref N,//ref Object MatchPrefix,
	                ref N,//ref Object MatchSuffix,
	                ref N,//ref Object MatchPhrase,
	                ref N,//ref Object IgnoreSpace,
	                ref N//ref Object IgnorePunct
                    );
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return flag;
        }


        /// <summary>
        /// 保存
        /// </summary>
        public void save ()
        {
            try
            {
                app.ActiveDocument.Save();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 关闭当前文档
        /// </summary>
        public void close()
        {
            try
            {
                 app.ActiveDocument.Close(ref nullObj, ref nullObj, ref nullObj);
                 doc = null;
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }
        /// <summary>
        /// 退出Word程序
        /// </summary>
        public void quitApplication()
        {
            try { 
                 app.Application.Quit(ref nullObj, ref nullObj, ref nullObj);
                 app = null;
            }catch(Exception ex){
                throw ex;
            }
           
        }

    }
}
