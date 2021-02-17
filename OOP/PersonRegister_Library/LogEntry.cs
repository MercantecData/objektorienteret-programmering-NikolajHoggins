using System;
namespace PersonRegister_Library
{
    public class LogEntry
    {
        //We keep the variables private as a log entry should not be changed
        private DateTime createdAt;
        private string action;

        public LogEntry(string action)
        {
            this.action = action;
            this.createdAt = DateTime.Now;
        }

        public string getAction()
        {
            return this.action;
        }
        public DateTime getCreatedAt()
        {
            return this.createdAt;
        }

    }
}
