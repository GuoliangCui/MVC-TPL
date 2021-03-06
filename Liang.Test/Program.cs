﻿using Liang.BLL;
using Liang.Model;
using Liang.Model.Query;
using Liang.Tools;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Liang.Test
{
    class Program
    {
        static ArrayList idSet = ArrayList.Synchronized(new ArrayList());
        //static ConcurrentQueue<long> idSet = new ConcurrentQueue<long>();
        static void Main(string[] args)
        {

            Logger logger = new Logger("测试");
            try
            {
               
                File.Open("",FileMode.Open);
            }
            catch (Exception ex)
            {
                
                Logger.Default.Error("sdfssdf",ex);
            }


            // QPSTest();//344.8w/s
            //TestRepeat();//并没发现

            var ss= IdBuilder.GetInstance().CreateId();
          
            Console.ReadLine();
        }
        static void TestRepeat() {
            List<Task> taskList = new List<Task>();

            for (int i = 0; i < 10; i++)
            {
                Task t2 = Task.Factory.StartNew(RepeatFuc);
                taskList.Add(t2);
            }
            Task.WaitAll(taskList.ToArray());

            Console.WriteLine("idSet数" + idSet.Count);
        }

        static void RepeatFuc()
        {

           
                var i = 0;
                while (i < 10000)
                {
                    var sid = IdBuilder.GetInstance().CreateId();
                    if (idSet.Contains(sid))
                    {
                        Console.WriteLine("发现有重复项");
                    }

                    idSet.Add(sid);
                    Console.Write(Thread.CurrentThread.ManagedThreadId);
                    i++;
                }
                Console.WriteLine(i);
            
        }

        static void QPSTest()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var i = 0;
            while (i < 1000000)
            {
                IdBuilder.GetInstance().CreateId();
                i++;
            }
            sw.Stop();
            var time = sw.ElapsedMilliseconds;
            Console.WriteLine("100万耗时" + time + "毫秒");
            var qps = (1000000 * 1000) / time;
            Console.WriteLine("QPS=" + qps + "个/秒");
        }
    }
}
