using Infracestructure.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Domain.Services.Interfaces
{
    public interface IUserServices
    {
        //Tareas Asíncronas o tareas en segundo plano 
        bool Login(string username, string password);
        public List<UsuarioEntity> GetAllUser();

    }
}
