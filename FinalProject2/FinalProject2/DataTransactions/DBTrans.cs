
using FinalProject2.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject2.DataTransactions
{
    public class DBTrans
    {
        public string dbPath;
        private SQLiteConnection conn;

        public DBTrans(string _dbPath)
        {
            this.dbPath = _dbPath;
            
            Init(); // Bağlantıyı burada açalım
        }

      

        public void Init()
        {
            if (conn == null)
            {
                conn = new SQLiteConnection(this.dbPath);
                conn.CreateTable<Student>();
                conn.CreateTable<Course>();
                conn.CreateTable<Enrollment>();
            }
        }

        public List<Student> GetAllStudents()
        {
            return conn.Table<Student>().ToList();
        }

        public void Add(Student student)
        {
            conn.Insert(student);
        }

        public void Delete(int student_ID)
        {
            conn.Delete(new Student { ID = student_ID });
        }

        public List<Course> GetAllCourses()
        {
            return conn.Table<Course>().ToList();
        }

        public void AddCourse(Course course)
        {
            conn.Insert(course);
        }

        public void DeleteCourse(int course_Code)
        {
            conn.Delete(new Course { Code = course_Code });
        }


        public void AddEnrollment(Enrollment enroll)
        {
            conn.Insert(enroll);
        }

        public List<Enrollment> GetAllEnrollment()
        {
            return conn.Table<Enrollment>().ToList();
        }

        public void DeleteEnrollment(int enrollment_ID)
        {
            conn.Delete(new Enrollment { Enroll_ID = enrollment_ID });
        }
    }
}
