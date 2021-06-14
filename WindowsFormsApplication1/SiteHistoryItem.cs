﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class SiteHistoryItem
    {

        public string Address { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public SiteHistoryItem(string address, string name,DateTime date)
        {
            Address = address;
            Name = name;
            Date = date;
        }
        public override string ToString()
        {
            return Name +$"({Address})";
        }
    }
}