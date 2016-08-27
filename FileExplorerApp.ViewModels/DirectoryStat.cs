﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorerApp.ViewModels
{
    public class DirectoryStat
    {
        public string FullPath { get; set; }

        public string Info { get; set; }

        public bool isComplete { get; set; }

        public int ContinueCursor { get; set; }

        public int Less10mb { get; set; }

        public int Range10_50mb { get; set; }

        public int More100mb { get; set; }
    }
}