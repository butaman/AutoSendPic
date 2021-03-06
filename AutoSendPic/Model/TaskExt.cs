﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace AutoSendPic.Model
{
    public static class TaskExt
    {

        //以下のコードは、http://neue.cc/2012/10/16_383.html を使用
        /*
        public static Task Timeout(this Task task, TimeSpan timeout)
        {
            Task delay = Task.Delay(timeout);
            if (await Task.WhenAny(task, delay) == delay)
            {
                throw new TimeoutException();
            }
        }

        public static Task<T> Timeout<T>(this Task<T> task, TimeSpan timeout)
        {
            await Timeout((Task)task, timeout);
            return await task;
        }*/

        public static Task Run(Action act)
        {
            return Task.Factory.StartNew(act,
                                  CancellationToken.None,
                                  TaskCreationOptions.None,
                                  TaskScheduler.Default);
        }
    }
}
