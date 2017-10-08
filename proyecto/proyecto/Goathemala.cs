using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Goathemala
    {
        private static Usuario[] congreso = new Usuario[100];        
        private static int cont = 0;
        //agrega un nuevo usuario 
        public static void addPolitico(Usuario politicos)
        {
            congreso[cont] = politicos;
            cont++;
        }
        //codigo para el inicio de secion
        public static bool buscar(string name, string password)
        {            
            bool permitido = false;
            for (int i = 0; i < congreso.Length; i++)
            {
                if (name == congreso[i].getUser())
                {
                    if (password.Equals(congreso[i].getPassword()))
                    {
                        permitido = true;
                    }
                }
            }            
            return permitido;
        }
    }
}
