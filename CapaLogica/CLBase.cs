using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaLogica
{
    public class CLBase
    {
        CDAfiliados objDatosAfiliados = new CDAfiliados();

        public List<string> TraerPLanes()
        {
            CDPlanes objDatosPlanes = new CDPlanes();
            
            return objDatosPlanes.TraerPlanes();
        }

        public int TraerPlanAFiliado(string paramId)
        {
            return objDatosAfiliados.TraerPlanAfiliados(paramId);
        }

        public DataSet TraerAfiliados()
        {
            DataSet ds = objDatosAfiliados.LeerAfiliados();
            return ds;
        }

        public void Create(CEAfiliados paramAfiliado) 
        {
            objDatosAfiliados.Create(paramAfiliado);
        }

        public void Update(CEAfiliados paramAfiliado)
        {
            objDatosAfiliados.Update(paramAfiliado);
        }

        public void BajaAfiliado(CEAfiliados paramAfiliado)
        {
            objDatosAfiliados.BajaAfiliado(paramAfiliado);
        }

        public void HabilitarAfiliado(CEAfiliados paramAfiliado)
        {
            objDatosAfiliados.HabilitarAfiliados(paramAfiliado);
        }

        public DataSet TraerAfiliadosInactivos()
        {
            DataSet ds = objDatosAfiliados.LeerAfiliadosInactivos();
            return ds;
        }

    }
}
