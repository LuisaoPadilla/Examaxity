using System;
using System.Collections.Generic;

namespace ExamaxityApp.Models
{
    public partial class Users
    {
        public int IdUser { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Password { get; set; }
        public int? Activo { get; set; }
    }
}
