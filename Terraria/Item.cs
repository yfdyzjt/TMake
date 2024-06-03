﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMake.Terraria
{
    public class Item
    {
        public int StackSize { get; set; }
        public byte Prefix { get; set; }
        public int Type { get; set; }
        public bool IsValid => StackSize > 0 && Type > 0;
    }
}
