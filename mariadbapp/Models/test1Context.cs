using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace mariadbapp.Models
{
    public partial class test1Context : DbContext
    {
        public test1Context()
        {
        }

        public test1Context(DbContextOptions<test1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<MdlxgCourse> MdlxgCourse { get; set; }
        public virtual DbSet<MdlxgCourseCategories> MdlxgCourseCategories { get; set; }
        public virtual DbSet<MdlxgUser> MdlxgUser { get; set; }
        public virtual DbSet<MdlxgUserLastaccess> MdlxgUserLastaccess { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;database=test1;user=root;password=test1;treattinyasboolean=true", x => x.ServerVersion("10.5.4-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MdlxgCourse>(entity =>
            {
                entity.ToTable("mdlxg_course");

                entity.HasComment("Central course table");

                entity.HasIndex(e => e.Category)
                    .HasName("mdlxg_cour_cat_ix");

                entity.HasIndex(e => e.Idnumber)
                    .HasName("mdlxg_cour_idn_ix");

                entity.HasIndex(e => e.Shortname)
                    .HasName("mdlxg_cour_sho_ix");

                entity.HasIndex(e => e.Sortorder)
                    .HasName("mdlxg_cour_sor_ix");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Cacherev)
                    .HasColumnName("cacherev")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Calendartype)
                    .IsRequired()
                    .HasColumnName("calendartype")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Completionnotify).HasColumnName("completionnotify");

                entity.Property(e => e.Defaultgroupingid)
                    .HasColumnName("defaultgroupingid")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Enablecompletion).HasColumnName("enablecompletion");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Format)
                    .IsRequired()
                    .HasColumnName("format")
                    .HasColumnType("varchar(21)")
                    .HasDefaultValueSql("'topics'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fullname)
                    .IsRequired()
                    .HasColumnName("fullname")
                    .HasColumnType("varchar(254)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Groupmode)
                    .HasColumnName("groupmode")
                    .HasColumnType("smallint(4)");

                entity.Property(e => e.Groupmodeforce)
                    .HasColumnName("groupmodeforce")
                    .HasColumnType("smallint(4)");

                entity.Property(e => e.Idnumber)
                    .IsRequired()
                    .HasColumnName("idnumber")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lang)
                    .IsRequired()
                    .HasColumnName("lang")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Legacyfiles)
                    .HasColumnName("legacyfiles")
                    .HasColumnType("smallint(4)");

                entity.Property(e => e.Marker)
                    .HasColumnName("marker")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Maxbytes)
                    .HasColumnName("maxbytes")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Newsitems)
                    .HasColumnName("newsitems")
                    .HasColumnType("mediumint(5)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Relativedatesmode).HasColumnName("relativedatesmode");

                entity.Property(e => e.Requested).HasColumnName("requested");

                entity.Property(e => e.Shortname)
                    .IsRequired()
                    .HasColumnName("shortname")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Showgrades)
                    .HasColumnName("showgrades")
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Showreports)
                    .HasColumnName("showreports")
                    .HasColumnType("smallint(4)");

                entity.Property(e => e.Sortorder)
                    .HasColumnName("sortorder")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Summary)
                    .HasColumnName("summary")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Summaryformat)
                    .HasColumnName("summaryformat")
                    .HasColumnType("tinyint(2)");

                entity.Property(e => e.Theme)
                    .IsRequired()
                    .HasColumnName("theme")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Timecreated)
                    .HasColumnName("timecreated")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Timemodified)
                    .HasColumnName("timemodified")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Visible)
                    .IsRequired()
                    .HasColumnName("visible")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Visibleold)
                    .IsRequired()
                    .HasColumnName("visibleold")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<MdlxgCourseCategories>(entity =>
            {
                entity.ToTable("mdlxg_course_categories");

                entity.HasComment("Course categories");

                entity.HasIndex(e => e.Parent)
                    .HasName("mdlxg_courcate_par_ix");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Coursecount)
                    .HasColumnName("coursecount")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Depth)
                    .HasColumnName("depth")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Descriptionformat)
                    .HasColumnName("descriptionformat")
                    .HasColumnType("tinyint(2)");

                entity.Property(e => e.Idnumber)
                    .HasColumnName("idnumber")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Parent)
                    .HasColumnName("parent")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sortorder)
                    .HasColumnName("sortorder")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Theme)
                    .HasColumnName("theme")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Timemodified)
                    .HasColumnName("timemodified")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Visible)
                    .IsRequired()
                    .HasColumnName("visible")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Visibleold)
                    .IsRequired()
                    .HasColumnName("visibleold")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<MdlxgUser>(entity =>
            {
                entity.ToTable("mdlxg_user");

                entity.HasComment("One record for each person");

                entity.HasIndex(e => e.Alternatename)
                    .HasName("mdlxg_user_alt_ix");

                entity.HasIndex(e => e.Auth)
                    .HasName("mdlxg_user_aut_ix");

                entity.HasIndex(e => e.City)
                    .HasName("mdlxg_user_cit_ix");

                entity.HasIndex(e => e.Confirmed)
                    .HasName("mdlxg_user_con_ix");

                entity.HasIndex(e => e.Country)
                    .HasName("mdlxg_user_cou_ix");

                entity.HasIndex(e => e.Deleted)
                    .HasName("mdlxg_user_del_ix");

                entity.HasIndex(e => e.Email)
                    .HasName("mdlxg_user_ema_ix");

                entity.HasIndex(e => e.Firstname)
                    .HasName("mdlxg_user_fir_ix");

                entity.HasIndex(e => e.Firstnamephonetic)
                    .HasName("mdlxg_user_fir2_ix");

                entity.HasIndex(e => e.Idnumber)
                    .HasName("mdlxg_user_idn_ix");

                entity.HasIndex(e => e.Lastaccess)
                    .HasName("mdlxg_user_las2_ix");

                entity.HasIndex(e => e.Lastname)
                    .HasName("mdlxg_user_las_ix");

                entity.HasIndex(e => e.Lastnamephonetic)
                    .HasName("mdlxg_user_las3_ix");

                entity.HasIndex(e => e.Middlename)
                    .HasName("mdlxg_user_mid_ix");

                entity.HasIndex(e => new { e.Mnethostid, e.Username })
                    .HasName("mdlxg_user_mneuse_uix")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Aim)
                    .IsRequired()
                    .HasColumnName("aim")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Alternatename)
                    .HasColumnName("alternatename")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Auth)
                    .IsRequired()
                    .HasColumnName("auth")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'manual'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Autosubscribe)
                    .IsRequired()
                    .HasColumnName("autosubscribe")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Calendartype)
                    .IsRequired()
                    .HasColumnName("calendartype")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("'gregorian'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Confirmed).HasColumnName("confirmed");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasColumnType("varchar(2)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Currentlogin)
                    .HasColumnName("currentlogin")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasColumnName("department")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Descriptionformat)
                    .HasColumnName("descriptionformat")
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Emailstop).HasColumnName("emailstop");

                entity.Property(e => e.Firstaccess)
                    .HasColumnName("firstaccess")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Firstnamephonetic)
                    .HasColumnName("firstnamephonetic")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Icq)
                    .IsRequired()
                    .HasColumnName("icq")
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Idnumber)
                    .IsRequired()
                    .HasColumnName("idnumber")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Imagealt)
                    .HasColumnName("imagealt")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Institution)
                    .IsRequired()
                    .HasColumnName("institution")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lang)
                    .IsRequired()
                    .HasColumnName("lang")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("'en'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lastaccess)
                    .HasColumnName("lastaccess")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Lastip)
                    .IsRequired()
                    .HasColumnName("lastip")
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lastlogin)
                    .HasColumnName("lastlogin")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lastnamephonetic)
                    .HasColumnName("lastnamephonetic")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Maildigest).HasColumnName("maildigest");

                entity.Property(e => e.Maildisplay)
                    .HasColumnName("maildisplay")
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.Mailformat)
                    .IsRequired()
                    .HasColumnName("mailformat")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Middlename)
                    .HasColumnName("middlename")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mnethostid)
                    .HasColumnName("mnethostid")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Moodlenetprofile)
                    .HasColumnName("moodlenetprofile")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Msn)
                    .IsRequired()
                    .HasColumnName("msn")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Phone1)
                    .IsRequired()
                    .HasColumnName("phone1")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Phone2)
                    .IsRequired()
                    .HasColumnName("phone2")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Picture)
                    .HasColumnName("picture")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Policyagreed).HasColumnName("policyagreed");

                entity.Property(e => e.Secret)
                    .IsRequired()
                    .HasColumnName("secret")
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Skype)
                    .IsRequired()
                    .HasColumnName("skype")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Suspended).HasColumnName("suspended");

                entity.Property(e => e.Theme)
                    .IsRequired()
                    .HasColumnName("theme")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Timecreated)
                    .HasColumnName("timecreated")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Timemodified)
                    .HasColumnName("timemodified")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Timezone)
                    .IsRequired()
                    .HasColumnName("timezone")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'99'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Trackforums).HasColumnName("trackforums");

                entity.Property(e => e.Trustbitmask)
                    .HasColumnName("trustbitmask")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Yahoo)
                    .IsRequired()
                    .HasColumnName("yahoo")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<MdlxgUserLastaccess>(entity =>
            {
                entity.ToTable("mdlxg_user_lastaccess");

                entity.HasComment("To keep track of course page access times, used in online pa");

                entity.HasIndex(e => e.Courseid)
                    .HasName("mdlxg_userlast_cou_ix");

                entity.HasIndex(e => e.Userid)
                    .HasName("mdlxg_userlast_use_ix");

                entity.HasIndex(e => new { e.Userid, e.Courseid })
                    .HasName("mdlxg_userlast_usecou_uix")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Courseid)
                    .HasColumnName("courseid")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Timeaccess)
                    .HasColumnName("timeaccess")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasColumnType("bigint(10)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
