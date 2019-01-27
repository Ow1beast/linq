﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Player
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Number { get; set; }
        public virtual Team Team { get; set; }
    }
}
