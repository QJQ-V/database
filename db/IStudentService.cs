using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db
{
    interface IStudentService
    {
        void Add();
        void Update(int id);
        void GetStudents();
        void GetStudent(int id);
        void Delete(int id);
    }
}
