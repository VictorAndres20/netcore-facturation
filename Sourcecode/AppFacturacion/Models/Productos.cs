using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppFacturacion.Models
{
    public class Productos
    {
        [Key]
        public int idProducto{get;set;}

        [Required (ErrorMessage="Este dato es obligatorio")]
        public string Producto{get;set;}

        public ICollection<Detalles> Detalles { get; set; }
    }
}