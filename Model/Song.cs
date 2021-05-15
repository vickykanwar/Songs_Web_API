using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Web_API.Model
{
    public class Song
    {
        public int Id { get; set; }

        public string SongTitle { get; set; }

        public string Band { get; set; }

        public string Album { get; set; }

    }
}
