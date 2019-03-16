using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppFacturacion.Models
{
    public class Detalles
    {
        [Key]
        public int idDetalle{get;set;}

        [Required (ErrorMessage="Este dato es obligatorio")]
        public int idFactura{get;set;}

        [Required (ErrorMessage="Este dato es obligatorio")]
        public int idProducto{get;set;}

        [Range(1, 999999999)]
        [Required (ErrorMessage="Este dato es obligatorio")]
        public int Cantidad{get;set;}

        [Range(0, 999999999)]
        [Required (ErrorMessage="Este dato es obligatorio")]
        public int PrecioUnitario{get;set;}

        public Productos Productos{get;set;}
        public Facturas Facturas{get;set;}

    }
}
