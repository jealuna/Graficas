using Graficas.Models.Analitica;
using Graficas.Models.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graficas.BLL.Analitica
{
    public class ObtieneDatos : MyDispose
    {
        public List<ItemDTO> GetDatos()
        {
            List<ItemDTO> Result = new List<ItemDTO>();
            using (DAL.Analitica.ObtieneDatos Metodo = new DAL.Analitica.ObtieneDatos())
            {
                Result = Metodo.GetDatos();
            }
            return Result;
        }
    }
}
