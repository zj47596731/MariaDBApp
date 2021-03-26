using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mariadbapp.Models
{
    public class UsersByCourse
    {
        public long courseid { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string username { get; set; }
    }
}
