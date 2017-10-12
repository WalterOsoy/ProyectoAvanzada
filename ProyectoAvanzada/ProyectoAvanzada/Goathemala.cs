using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvanzada
{
    class Goathemala
    {
        //atributos
        private static Usuario[] congreso = new Usuario[100];
        private static int cont = -1;
        //agrega un nuevo usuario 
        public static void addPolitico(Usuario politicos)
        {
            cont++;
            congreso[cont] = politicos;           
        }
        //codigo para el inicio de secion
        public static bool find(string name, string password)
        {
            bool permitido = false;
            for (int i = 0; i <= cont; i++)
            {
                if (name == congreso[i].getUser())
                {
                    if (password.Equals(congreso[i].getPassword()))
                    {
                        permitido = true;
                        return permitido;
                    }
                }
            }
            return permitido;
        }
    }
}
