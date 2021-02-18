using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exam_c_sharp
{
    public class FileLogger : ILog
    {
        public void LogInfo(string road , string mess)
        {
            var file = (File.Exists(road));

            using (var stream = File.OpenRead())
            {
            }
        }
    }
}
