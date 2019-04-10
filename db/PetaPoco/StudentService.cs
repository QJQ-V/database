using db.Petapoco.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db.PetaPoco
{
    public class StudentService
    {
        private TestDB _db;

        public StudentService() {
            _db = new TestDB();
        }

        public void Add()
        {
            Student student = new Student()
            {
                name = "张三",
                age = 20
            };

            _db.Insert(student);
        }

        public Student GetStudent(int id)
        {
            return _db.Single<Student>(id);
        }

        public List<Student> GetStudents()
        {
            var sql = "select * from dbo.Stundent";
            return _db.Fetch<Student>(sql);
        }

        public void Update(int id)
        {
            var student = _db.SingleOrDefault<Student>(id);

            student.name = "王五";
            _db.Update(student);
        }

        public void Delete(int id)
        {
            _db.Delete<Student>(id);
        }
    }
}
