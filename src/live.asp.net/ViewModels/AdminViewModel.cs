﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace live.asp.net.ViewModels
{
    public class AdminViewModel
    {
        [Display(Name = "Streaming Embed URL", Description = "URL for embedding the live show")]
        [DataType(DataType.Url)]
        public string LiveShowEmbedUrl { get; set; }

        public string SuccessMessage { get; set; }

        public bool ShowSucessMessage => !string.IsNullOrEmpty(SuccessMessage);
    }
}
