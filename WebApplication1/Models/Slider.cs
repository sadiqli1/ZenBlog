﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Image { get; set; }
       public string Title { get; set; }
        public string Subtitle { get; set; }
        public byte Order{ get; set; }
    }
}
