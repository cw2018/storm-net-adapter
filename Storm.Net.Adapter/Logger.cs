﻿namespace Storm
{
    public class Logger
    {
        public void Trace(string Message, params object[] args)
        {
            SendLog(string.Format(Message, args), 0);
        }
        public void Debug(string Message, params object[] args)
        {
            SendLog(string.Format(Message, args), 1);
        }
        public void Info(string Message, params object[] args)
        {
            SendLog(string.Format(Message, args), 2);
        }
        public void Warn(string Message, params object[] args)
        {
            SendLog(string.Format(Message, args), 3);
        }
        public void Error(string Message, params object[] args)
        {
            SendLog(string.Format(Message, args), 4);
        }
        private void SendLog(string Message, int level = 2)
        {
            Storm.SendMsgToParent("{\"command\": \"log\", \"msg\": " + Message + ", \"level\":" + level + "}");
        }
    }
}