using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend_Baza.Data
{
    public class KorisniciDA
    {
        public static List<prikaz_gradova_cmbx_Result> getGradoveCMBX()
        {
            return Connections.datamodel.prikaz_gradova_cmbx().ToList();
        }
    }
}
