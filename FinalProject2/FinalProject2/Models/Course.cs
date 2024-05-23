using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject2.Models
{
    public class Course
    {
        [PrimaryKey, AutoIncrement]
        public int Code { get; set; }
        public string CourseName { get; set; }
    }
}
