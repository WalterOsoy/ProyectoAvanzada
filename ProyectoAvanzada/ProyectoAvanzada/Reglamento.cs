using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvanzada
{
    public class Reglamento
    {
        private string titulo;
        private string info;
        private int copias = 5;

        public Reglamento(string titulo, string info)
        {
            this.titulo = titulo;
            this.info = info;
        }

    }
}
