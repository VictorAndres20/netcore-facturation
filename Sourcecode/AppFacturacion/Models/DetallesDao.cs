using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppFacturacion.Models;

namespace AppFacturacion.Controllers
{
    /**
    * Clase que hace referencia al DAO de la entidad Detalles
     */
    public static class DetallesDao
    {
        public static async Task<bool> CrearNuevoDetalles(FacturacionContext context,int codigoProducto,int cantidadProducto,int precioProducto)
        {
            try
            {
                Detalles detalle=new Detalles();
                detalle.idFactura=codigoProducto;
                detalle.idProducto=codigoProducto;
                detalle.Cantidad=cantidadProducto;
                detalle.PrecioUnitario=precioProducto;
                context.Detalles.Add(detalle);
                await context.SaveChangesAsync();
                System.Diagnostics.Debug.WriteLine("SE CREO El DETALLE");
                return true;
            }
            catch (Exception e)
            {
                /**
                * Se podría monitorear los errores,
                * En este caso simplemente escribimos en consola
                 */
                 System.Diagnostics.Debug.WriteLine("ERROR: "+e);
                return false;
            }
            
        }
    }
}