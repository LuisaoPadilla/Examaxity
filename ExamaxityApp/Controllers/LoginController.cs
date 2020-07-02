using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamaxityApp.Models;
using ExamaxityApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamaxityApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository repository;
        public LoginController(ILoginRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        public async Task<ActionResult> Get([FromBody] Users user)
        {
            var login = await repository.Login(user);
            if (login)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}