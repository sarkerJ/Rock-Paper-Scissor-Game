﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorBusinessLayer
{
    public interface IPlayer
    {
        public string PlayerName { get; set; }
        public Move Move { get; set; }
    }
}