using System;
using System.Collections.Generic;

namespace mariadbapp.Models
{
    public partial class MdlxgUser
    {
        public long Id { get; set; }
        public string Auth { get; set; }
        public bool Confirmed { get; set; }
        public bool Policyagreed { get; set; }
        public bool Deleted { get; set; }
        public bool Suspended { get; set; }
        public long Mnethostid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Idnumber { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public bool Emailstop { get; set; }
        public string Icq { get; set; }
        public string Skype { get; set; }
        public string Yahoo { get; set; }
        public string Aim { get; set; }
        public string Msn { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Institution { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Lang { get; set; }
        public string Calendartype { get; set; }
        public string Theme { get; set; }
        public string Timezone { get; set; }
        public long Firstaccess { get; set; }
        public long Lastaccess { get; set; }
        public long Lastlogin { get; set; }
        public long Currentlogin { get; set; }
        public string Lastip { get; set; }
        public string Secret { get; set; }
        public long Picture { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public sbyte Descriptionformat { get; set; }
        public bool? Mailformat { get; set; }
        public bool Maildigest { get; set; }
        public sbyte Maildisplay { get; set; }
        public bool? Autosubscribe { get; set; }
        public bool Trackforums { get; set; }
        public long Timecreated { get; set; }
        public long Timemodified { get; set; }
        public long Trustbitmask { get; set; }
        public string Imagealt { get; set; }
        public string Lastnamephonetic { get; set; }
        public string Firstnamephonetic { get; set; }
        public string Middlename { get; set; }
        public string Alternatename { get; set; }
        public string Moodlenetprofile { get; set; }
    }
}
