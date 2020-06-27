﻿using System.Collections.Generic;

namespace Permabuffs_V2
{
    public class DBInfo
    {
        public List<int> bufflist;

        public DBInfo(string activeBuffs)
        {
            this.bufflist = new List<int>();

            string[] buffstring = null;

            if (activeBuffs != "")
            {
                buffstring = activeBuffs.Split(',');
                foreach (var buff in buffstring)
                {
                    if (int.TryParse(buff, out var tempbuff))
                    {
                        this.bufflist.Add(tempbuff);
                    }
                }
            }
        }
    }
}
