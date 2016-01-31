using System;
using log4net;

namespace log4net.ES.Example
{
    class Program
    {
        // Create a new logging instance
        private static readonly ILog _log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            // Most basic logging example.
            _log.ErrorFormat("System Error {0}", "Divide by zero error.");

            
            // Log a message with an exeption object
            _log.Error("System Error", new Exception("Something terrible happened."));


            // Log an exception object with custom fields in the Data property
            Exception newException = new Exception("There was a system error");
            newException.Data.Add("CustomProperty", "CustomPropertyValue");
            newException.Data.Add("SystemUserID", "User43");

            _log.Error("Something broke.", newException);

        }
    }

 
}
