﻿using System;
using System.Collections.Generic;

namespace DevChatter.DevStreams.Web.Data.Model
{
    public class Stream
    {
        public string Name { get; set; }
        public Uri Uri { get; set; }
        public List<StreamTime> StreamTimes { get; set; }
    }
}