using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject2.Models
{
    public class Enrollment
    {
        [PrimaryKey, AutoIncrement]
        public int Enroll_ID { get; set; }

        public int Stu_ID { get; set; }

        public int Crs_Code { get; set; }
    }
}
