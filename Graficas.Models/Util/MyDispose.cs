using System;
using System.Collections.Generic;
using System.Text;

namespace Graficas.Models.Util
{
    public class MyDispose : IDisposable
    {
        private bool _estaDispuesto;

        protected virtual void Dispose(bool disposing)
        {
            if (_estaDispuesto)
            {
                _estaDispuesto = false;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
