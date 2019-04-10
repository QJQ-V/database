using db.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db
{
    class Program
    {
        static void Main(string[] args)
        {
            #region EntityFramework
            //StudentService studentService = new StudentService();

            //studentService.Add();
            //studentService.Update(1);
            //var students = studentService.GetStudents();
            //var student = studentService.GetStudent(1);
            //studentService.Delete(2);

            #endregion

            #region PetaPoco

            db.PetaPoco.StudentService studentService2 = new db.PetaPoco.StudentService();
            studentService2.Add();

            #endregion

            Console.WriteLine("操作成功");
            Console.ReadKey();
        }
    }
}
