using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CEAfiliados
    {
        public int idAfiliado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int idPLan { get; set; }
        public DateTime fAlta { get; set; }
        public DateTime fBaja { get; set; }
        public string observaciones { get; set; }

    }
}
