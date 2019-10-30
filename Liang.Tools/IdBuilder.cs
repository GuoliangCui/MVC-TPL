using System;
using System.Collections.Generic;
using System.Text;

namespace Liang.Tools
{
    /// <summary>
    /// 雪花算法Id生成器
    /// </summary>
    public sealed class IdBuilder
    {
        //0 - 0000000000 0000000000 0000000000 0000000000 0 - 00000 - 00000 - 000000000000
        // \                                               /  \            /  \          /
        //  -----------   41位时间戳 可存69.7年   ---------    -中心机器Id-    --顺序号--
        #region 变量
        private const int TIME_LEFT = 22;
        private const int DATACENTERID_LEFT = 17;
        private const int WORKID_LEFT = 12;
        private const long MAX_SEQUENCE = -1L ^ -1L << 12;
        private const long MAX_WCID = -1L ^ -1L << 5;

        private static long PrevTimeStamp = 0L;//上一个时间戳
        private static long Sequence = 0L;
        private static DateTime dt1970 = new DateTime(1970, 1, 1, 0, 0, 0, 0);
        private static long StartTimestamp = 1420070400000L;//2015-01-01 00:00:00
        private long CenterId = 0;
        private long WorkId = 0;
        private static object syncRoot = new object();

        private static IdBuilder idBuilder = null;
        private static object instanceRoot = new object();
        #endregion
        /// <summary>
        /// 获取Id生成器实例
        /// </summary>
        /// <param name="centerId"></param>
        /// <param name="workId"></param>
        /// <returns></returns>
        public static IdBuilder GetInstance(long centerId=0,long workId=0)
        {
            if (idBuilder==null)
            {
                lock (instanceRoot)
                {
                    if (idBuilder == null)
                    {
                        idBuilder = new IdBuilder(centerId,workId);
                    }
                }
            }
            return idBuilder;
        }

        /// <summary>
        /// 实例化Id生成器
        /// </summary>
        /// <param name="centerId">数据中心Id(默认0)</param>
        /// <param name="workId">机器Id(默认0)</param>
        private IdBuilder(long centerId, long workId)
        {
            if (centerId> MAX_WCID)
            {
                throw new Exception("CenterId 超出最大值");
            }
            if (workId> MAX_WCID)
            {
                throw new Exception("WorkId 超出最大值");
            }
            this.CenterId = centerId;
            this.WorkId = workId;
        }
        /// <summary>
        /// 生成唯一Id
        /// </summary>
        /// <returns></returns>
        public long CreateId()
        {
            lock (syncRoot)
            {
                long LastTimeStamp = GetTimestamp();
                if (PrevTimeStamp == LastTimeStamp)
                {
                    Sequence = (Sequence + 1) & MAX_SEQUENCE;
                    if (Sequence == 0)
                    {
                        PrevTimeStamp = GetTimestamp(LastTimeStamp);
                    }
                }
                else
                {
                    Sequence = 0;
                    PrevTimeStamp = LastTimeStamp;
                }

                return (PrevTimeStamp - StartTimestamp) << TIME_LEFT | CenterId << DATACENTERID_LEFT | WorkId << WORKID_LEFT | Sequence;
            }
        }
        /// <summary>
        ///  获取下一毫秒时间戳
        /// </summary>
        /// <param name="prevTimestamp">当前时间戳</param>
        /// <returns></returns>
        private long GetTimestamp(long prevTimestamp=0L)
        {
            if (prevTimestamp>0)
            {
                long timeStamp = GetTimestamp();
                while (timeStamp <= prevTimestamp)
                {
                    timeStamp = GetTimestamp();
                }
                return timeStamp;
            }
            else {
                TimeSpan ts = DateTime.UtcNow - dt1970;
                return Convert.ToInt64(ts.TotalMilliseconds);
            }
        }
    }
}
