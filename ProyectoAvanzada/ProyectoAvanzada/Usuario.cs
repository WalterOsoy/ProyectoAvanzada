using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvanzada
{
    class Usuario
    {
        //atributos
        private string name;
        private string lastname;
        private string user;
        public int job;//1 diputado, 2 asesor        
        private string password;

        //construccot 
        public Usuario(string name, string lastname, string user, int job, string password)
        {
            this.name = name;
            this.lastname = lastname;
            this.user = user;
            this.job = job;
            this.password = password;
        }
        //getters y setters de los atributos
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setLastname(string last)
        {
            this.lastname = last;
        }
        public string getLastname()
        {
            return this.lastname;
        }
        public void setUser(string user)
        {
            this.user = user;
        }
        public string getUser()
        {
            return this.user;
        }
        public void setJob(int job)
        {
            this.job = job;
        }
        public int getJob()
        {        
            return job;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public string getPassword()
        {
            return password;
        }
    }
}
