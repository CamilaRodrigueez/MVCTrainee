using Infracestructure.Entity.Entity;
using MVC.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Domain.Services
{
    public class UserServices : IUserServices
    {
        public bool Login(string username, string password)
        {
            bool result = false;
            if(username == "mcrodriguez" && password == "123")   
                result = true;  
            return result;
        }
        public List<UsuarioEntity> GetAllUser()
        {
            List<UsuarioEntity> users = new List<UsuarioEntity>();
            for (int i = 0; i <15; i++)
            {
                users.Add(new UsuarioEntity()
                {
                    UserName = $"user {i}",
                    Password = $"Pass {i}",
                    Name = $"Name {i}",
                    LastName = $"Last {i}",
                });
            }


            return users;
        }
    }
}
