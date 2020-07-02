using System;
using System.Collections.Generic;

namespace ExamaxityApp.Models
{
    public partial class Products
    {
        public int IdProduct { get; set; }
        public string Nombre { get; set; }
        public string Costo { get; set; }
        public string CantidadInventario { get; set; }
    }
}
