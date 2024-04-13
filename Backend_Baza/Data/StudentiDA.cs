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
        
        public static List<prikazi_spisak_predmeta_studenta_Result> getPredmete()
        {
            return Connections.datamodel.prikazi_spisak_predmeta_studenta().ToList();
        }

        public static List<prikaz_ocjena_predmeta_ucenika_po_studentID_Result> getOcjene(int studentID)
        {
            return Connections.datamodel.prikaz_ocjena_predmeta_ucenika_po_studentID(studentID).ToList();
        }
    }
}
