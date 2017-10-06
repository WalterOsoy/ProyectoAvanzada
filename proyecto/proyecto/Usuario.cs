using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Usuario
    {
        private string user;
        private string password;
        public Usuario(string user, string password)
        {
            this.user = password;
            this.password = password;
        }
        public void setUser(string user)
        {
            this.user = user;
        }
        public string getUser()
        {
            return user;
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
