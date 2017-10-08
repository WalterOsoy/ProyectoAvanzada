using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Usuario
    {
<<<<<<< HEAD
        //atributos
        private string name;
        private string lastname;
        private string user;
        public int job;//1 diputado, 2 asesor        
        private string password;
        
        //construccot 
        public Usuario(string name, string lastname, string user,int job,string password)
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
=======
        private string user;
        private string password;
        public Usuario(string user, string password)
        {
            this.user = password;
            this.password = password;
        }
>>>>>>> 684caf237c61338eee419c08678957cea6c73cf1
        public void setUser(string user)
        {
            this.user = user;
        }
        public string getUser()
        {
<<<<<<< HEAD
            return this.user;
        }
        public void setJob(int job)
        {
            this.job = job;
        }
        public int getJob()
        {
            return this.job;
=======
            return user;
>>>>>>> 684caf237c61338eee419c08678957cea6c73cf1
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public string getPassword()
        {
            return password;
        }
<<<<<<< HEAD
        
=======
>>>>>>> 684caf237c61338eee419c08678957cea6c73cf1
    }
}
