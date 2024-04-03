using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend_Baza.Data
{
    public class StudentiDA
    {
        public static void RegisterNewStudent(Studenti student)
        {
            Connections.datamodel.RegisterStudent(student.imeStudenta, student.prezimeStudenta, student.datumRodjenjaStudenta,
                student.gradID, student.emailStudenta, student.indexStudenta);
        }
    }
}
