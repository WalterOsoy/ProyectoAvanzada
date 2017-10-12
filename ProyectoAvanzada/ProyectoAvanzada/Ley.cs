using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvanzada
{
     public class Ley
    {
        private string titulo;
        private string info;
        private int copias=5;
        public Reglamento[] reglamento = new Reglamento[100];
        private int numeRegla;
        
        public void addLey(string _titulo, string _info)
        {
            this.titulo = _titulo;
            this.info = _info;
                        
        }
    }
}
