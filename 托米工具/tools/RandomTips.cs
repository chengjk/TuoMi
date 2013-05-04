using System;
using System.Collections.Generic;

using System.Text;

namespace 托米工具.tools
{
    class RandomTips
    {
         static string[]  executingTips = {
                                          "嘘！已经在执行了...",
                                          "别点了，完成时会通知你的！" ,
                                          "不要着急...着急..急..."
                                          };
        
        private static int getRandom()
        {
            return new Random().Next(10);
        }
        public static string getExecutingTip()
        {
            int i = getRandom() % executingTips.Length;
            return executingTips[i].ToString();
        }

    }
}
