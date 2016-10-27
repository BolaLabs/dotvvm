﻿using DotVVM.Framework.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotVVM.Samples.BasicSamples.ViewModels.FeatureSamples.ReturnedFile
{
    public class ReturnedFileSampleViewModel: DotvvmViewModelBase
    {
        public string Text { get; set; } = "";
        public void GetFile()
        {
            Context.ReturnFile(Encoding.UTF8.GetBytes(Text), "file.txt", "text/plain");
        }
    }
}
