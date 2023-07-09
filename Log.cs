using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBTool
{
    internal class Log
    {
        List<string> log;
        string exepath;

        public Log()
        {
            exepath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            if(!exepath.EndsWith(@"\"))
            {
                exepath += @"\";
            }
            log = File.ReadAllLines(exepath + "log.log").ToList();

        }

        public void LogSave(string message)
        {
            string now = DateTime.Now.ToString(@"yyyy-MM-dd hh:mm:ss");
            log.Add(now + " " + message);

            while(log.Count > 10000)
            {
                log.RemoveAt(0);
            }

            try
            {
                TextWriter logFile = new StreamWriter(exepath + "log.log");
                foreach (string line in log)
                {
                    logFile.WriteLine(line);
                }
                logFile.Close();
            } catch (IOException e)
            {
                // coś wymyśl
            }
        }
    }
}
