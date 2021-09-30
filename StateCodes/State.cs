﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCodes
{
    class State
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public State() { }
        public State (string code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}
