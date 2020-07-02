using ExamaxityApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamaxityApp.Services
{
    public interface ILoginRepository
    {
        Task<bool> Login(Users user);
    }
}
