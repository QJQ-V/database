using db.EntityFramework.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db.EntityFramework
{
    public class StudentService
    {
        public void Add()
        {
            student student = new student()
            {
                name = "张三",
                age = 18
            };

            using (testEntities db = new testEntities())
            {
                db.student.Add(student);
                db.SaveChanges();
            }
        }

        public student GetStudent(int id)
        {
            using (testEntities db = new testEntities())
            {
                var student = db.student.FirstOrDefault(r => r.id == id);
                return student;
            }
        }

        public List<student> GetStudents()
        {
            using (testEntities db = new testEntities())
            {
                var students = db.student.ToList();
                return students;
            }
        }

        public void Update(int id)
        {
            using (testEntities db = new testEntities())
            {
                var student = db.student.FirstOrDefault(r => r.id == id);
                student.name = "李四";
                db.student.Attach(student);

                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (testEntities db = new testEntities())
            {
                var student = db.student.FirstOrDefault(r => r.id == id);
                db.student.Remove(student);
                db.SaveChanges();
            }
        }
    }
}
