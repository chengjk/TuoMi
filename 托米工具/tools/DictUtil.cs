using System;
using System.Collections;

using System.Text;
using System.IO;
namespace 托米工具.tools
{
    class DictUtil
    {
        /// <summary>
        /// 读取字典表。
        /// </summary>
        /// <param name="path">字典表的全路径</param>
        /// <returns></returns>
        public static ArrayList read(string path)
        {
            ArrayList dict = new ArrayList();
            FileStream fs = null;
            StreamReader m_streamReader = null;
            try
            {
                fs = new FileStream(path, FileMode.Open);
                m_streamReader = new StreamReader(fs, System.Text.Encoding.Default);
                m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                string strLine = "";
                while (strLine != null)
                {
                    strLine = m_streamReader.ReadLine();
                    if (strLine == null) break;
                    strLine=strLine.Replace("，",",");
                    dict.Add(strLine);
                  //  Console.WriteLine(strLine);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return null;
            }
            finally
            {
                m_streamReader.Close();
                m_streamReader.Dispose();
                fs.Close();
                fs.Dispose();
            }
            return sortByLength(dict);
        }

        /// <summary>
        /// 字典表排序，字符串长度越长越靠前。
        /// 查找替换的时候应该先长后短，以免替换了短的之后长的匹配不上。
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static ArrayList sortByLength(ArrayList arr)
        {
            ArrayList result = new ArrayList();
            string strd="";
            string strr="";

            strd = arr[0].ToString();
            result.Add(strd);
            int i = 0;
            int j = 0;
            for ( i = 1; i < arr.Count; i++)
            {
                strd = arr[i].ToString();
                
                for ( j = 0; j < result.Count; j++)
                {
                    strr = result[j].ToString();
                    if (strd.Length > strr.Length)
                    {
                        result.Insert(j, strd);
                        break;
                    }
                }
                if (j == result.Count)
                {
                    result.Add(strd);
                }
                
            }
            /////
            //for ( j = 0; j < result.Count; j++)
            //{
            //    string strrr = result[j].ToString();
            //  //  Console.WriteLine(strrr);
            //}
            return result;
        }




    }
}
