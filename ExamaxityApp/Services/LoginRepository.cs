using ExamaxityApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamaxityApp.Services
{
    public class LoginRepository : ILoginRepository
    {
        private AppDbContext dbContext;

        public LoginRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> Login(Users user)
        {
            bool succes = false;
            try
            {
                var temp = await dbContext.Users.FirstOrDefaultAsync(x => x.Nombre == user.Nombre && x.Password == user.Password && x.Activo == 1);
                if (temp != null)
                {
                    succes = true;
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return succes;
        }
    }
}
