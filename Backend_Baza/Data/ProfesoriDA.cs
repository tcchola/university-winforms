using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend_Baza.Data
{
    public class ProfesoriDA
    {
        public static void RegisterNewProfessor(Profesori prof)
        {
            Connections.datamodel.RegisterProfesori(prof.imeProfesora, prof.prezimeProfesora, prof.datumRodjenjaProfesora,
                prof.gradID, prof.emailProfesora, prof.zvanjeProfesora);
        }
        
        public static List<prof_ocjenjivanja_Result> getOcjeneProf(int profID)
        {
            return Connections.datamodel.prof_ocjenjivanja(profID).ToList();
        }
    }
}
