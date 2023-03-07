using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CEAfiliadoPlanesAdicionales
    {
        public int idAfiliadoPlan { get; set; }
        public int idAFiliado { get; set; }
        public int idPLan { get; set; }
        public int porcentajeCobertura { get; set; }
    }
}
