using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppFacturacion.Models
{
    public class Facturas
    {
        [Key]
        public int idFactura{get;set;}

        [Required (ErrorMessage="Este dato es obligatorio")]
        public int NumeroFactura{get;set;}

        [Required (ErrorMessage="Este dato es obligatorio")]
        [DisplayFormat(DataFormatString="{0:dd/MM/yyyy}")]
        public DateTime Fecha{get;set;}

        [Required (ErrorMessage="Este dato es obligatorio")]
        public string TipodePago{get;set;}

        [Required (ErrorMessage="Este dato es obligatorio")]
        public int DocumentoCliente{get;set;}

        [Required (ErrorMessage="Este dato es obligatorio")]
        public string NombreCliente{get;set;}

        [Required (ErrorMessage="Este dato es obligatorio")]
        public int SubTotal{get;set;}

        [Range(0, 100)]
        [Required (ErrorMessage="Este dato es obligatorio")]
        public decimal Descuento{get;set;}

        [Range(0, 100)]
        [Required (ErrorMessage="Este dato es obligatorio")]
        public decimal IVA{get;set;}

        [Required (ErrorMessage="Este dato es obligatorio")]
        public decimal TotalDescuento{get;set;}

        [Required (ErrorMessage="Este dato es obligatorio")]
        public decimal TotalImpuesto{get;set;}

        [Required (ErrorMessage="Este dato es obligatorio")]
        public decimal Total{get;set;}

        public ICollection<Detalles> Detalles { get; set; }
    }
}