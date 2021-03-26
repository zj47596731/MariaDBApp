using System;
using System.Collections.Generic;

namespace mariadbapp.Models
{
    public partial class MdlxgUserLastaccess
    {
        public long Id { get; set; }
        public long Userid { get; set; }
        public long Courseid { get; set; }
        public long Timeaccess { get; set; }
    }
}
