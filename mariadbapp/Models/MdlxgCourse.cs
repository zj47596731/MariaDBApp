using System;
using System.Collections.Generic;

namespace mariadbapp.Models
{
    public partial class MdlxgCourse
    {
        public long Id { get; set; }
        public long Category { get; set; }
        public long Sortorder { get; set; }
        public string Fullname { get; set; }
        public string Shortname { get; set; }
        public string Idnumber { get; set; }
        public string Summary { get; set; }
        public sbyte Summaryformat { get; set; }
        public string Format { get; set; }
        public sbyte Showgrades { get; set; }
        public int Newsitems { get; set; }
        public long Startdate { get; set; }
        public long Enddate { get; set; }
        public bool Relativedatesmode { get; set; }
        public long Marker { get; set; }
        public long Maxbytes { get; set; }
        public short Legacyfiles { get; set; }
        public short Showreports { get; set; }
        public bool? Visible { get; set; }
        public bool? Visibleold { get; set; }
        public short Groupmode { get; set; }
        public short Groupmodeforce { get; set; }
        public long Defaultgroupingid { get; set; }
        public string Lang { get; set; }
        public string Calendartype { get; set; }
        public string Theme { get; set; }
        public long Timecreated { get; set; }
        public long Timemodified { get; set; }
        public bool Requested { get; set; }
        public bool Enablecompletion { get; set; }
        public bool Completionnotify { get; set; }
        public long Cacherev { get; set; }
    }
}
