using System;
using System.Collections.Generic;
using System.Text;

namespace Liang.Tools
{
    /// <summary>
    /// 日志类 (优先级低到高 Trace,Debug,Info,Error,Fatal)
    /// </summary>
    public class Logger
    {
        NLog.Logger logger;
        private Logger(NLog.Logger logger)
        {
            this.logger = logger;
        }
        public Logger(string name) : this(NLog.LogManager.GetLogger(name))
        {
        }
        /// <summary>
        /// Logger实例 
        /// </summary>
        public static Logger Default { get; private set; }
        static Logger() {
            Default = new Logger(NLog.LogManager.GetCurrentClassLogger());
        }

        public void Trace(string msg, params object[] args)
        {
            logger.Trace(msg, args);
        }
        public void Trace(string msg, Exception err, params object[] args)
        {
            logger.Trace(err, msg, err);
        }

        public void Debug(string msg,params object[] args)
        {
            logger.Debug(msg, args);
        }
        public void Debug(string msg, Exception err,params object[] args)
        {
            logger.Debug(err,msg,err);
        }
        
        public void Info(string msg, params object[] args)
        {
            logger.Info(msg, args);
        }
        public void Info(string msg, Exception err, params object[] args)
        {
            logger.Info(err, msg, err);
        }

        public void Error(string msg, params object[] args)
        {
            logger.Error(msg, args);
        }
        public void Error(string msg, Exception err, params object[] args)
        {
            logger.Error(err, msg, err);
        }

        public void Fatal(string msg, params object[] args)
        {
            logger.Fatal(msg, args);
        }
        public void Fatal(string msg, Exception err, params object[] args)
        {
            logger.Debug(err, msg, err);
        }

    }
}
