using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApplication
{
     
    
        public class MyClass
    {
        public delegate void LogHandler (string message);
        public void process(LogHandler loghandler)
        {
            if (loghandler != null)
            {
                loghandler("begin");
            }
            if(loghandler != null)
                                                       {
                loghandler("End");
            }
        }
        public class MyLogger
        {
            public void logger(string s)
            {
                Console.WriteLine(s);
            }
        }
        public class TestApplication
        {
            static void Logger(string s)
            {
                Console.WriteLine(s);
            }
            static void Main(string[] args)
            {
                MyLogger f1 = new MyLogger();
                MyClass myClass = new MyClass();
                MyClass.LogHandler myLogger = null;
                myLogger += new MyClass.LogHandler(Logger);
                myLogger += new MyClass.LogHandler(f1.logger);
                myClass.process(myLogger);
                return;
            }
        }
    }

}
