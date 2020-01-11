using Graficas.Models.Analitica;
using Graficas.Models.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graficas.DAL.Analitica
{
    public class ObtieneDatos : MyDispose
    {
        public List<ItemDTO> GetDatos()
        {
            List<ItemDTO> Result = new List<ItemDTO>() {
                new ItemDTO
                {
                    CantidadDerecha = 80000,
                    CantidadIzquierda = 120000,
                    EtiquetaDerecha = "Smartphone",
                    EtiquetaIzquierda = "Tablet",
                    TipoGrafica = "Revenue",
                    ColorIzquierda = "#87cf34",
                    ColorDerecha = "#3a661c"
                },
                new ItemDTO
                {
                    CantidadDerecha = 30000000,
                    CantidadIzquierda = 20000000,
                    EtiquetaDerecha = "Smartphone",
                    EtiquetaIzquierda = "Tablet",
                    TipoGrafica = "Impresions",
                    ColorIzquierda = "#809e9b",
                    ColorDerecha = "#295063"

                },
                new ItemDTO
                {
                    CantidadDerecha = 120000000,
                    CantidadIzquierda = 480000000,
                    EtiquetaDerecha = "Smartphone",
                    EtiquetaIzquierda = "Tablet",
                    TipoGrafica = "Visits",
                    ColorIzquierda = "#ecc229",
                    ColorDerecha = "#bd5417"
                }
            };
            return Result;
        }
    }
}
