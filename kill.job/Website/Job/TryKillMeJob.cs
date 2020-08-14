using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;
using Sitecore.Tasks;
using System.Threading;

namespace Website.Job
{
    public class TryKillMeJob
    {
        public void Run(Item[] items, CommandItem command, ScheduleItem schedule)
        {
            while (true)
            {
                Thread.Sleep(1000);
            }
        }
    }
}