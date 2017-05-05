﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExample
{
    class WeatherMap
    {
        public string Cod { get; set; }
        public string Message { get; set; }

        public WeatherCity City { get; set; }

        public List<Weather> List { get; set; }
    }
}
