﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMusicStore.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
    }
}