using DataAcces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Data
{
    public class Access
    {
        public List<Grades> GetGrades()
        {
            var db = new DanaosDBEntities();
            var gData = db.Grades.ToList();
            return gData;
        }

        public List<Students> GetStudents()
        {
            var db = new DanaosDBEntities();
            var sData = db.Students.ToList();
            return sData;
        }

    }
}
