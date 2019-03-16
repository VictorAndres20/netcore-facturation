using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppFacturacion.Models;

namespace AppFacturacion.Controllers
{
    public class FacturasController : Controller
    {
        private readonly FacturacionContext _context;

        public FacturasController(FacturacionContext context)
        {
            _context = context;
        }

        // GET: Facturas
        public async Task<IActionResult> Index()
        {
            var facturas=await _context.Facturas.ToListAsync();
            return View(facturas);
        }

        // GET: Facturas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facturas = await _context.Facturas
                .FirstOrDefaultAsync(m => m.idFactura == id);
            if (facturas == null)
            {
                return NotFound();
            }

            /**
            * Obtener los detalles de la factura para ver su historial
             */
            ViewData["detalles"]=await _context.Detalles.Where(d => d.idFactura == id).Include(d => d.Productos).ToListAsync();

            return View(facturas);
        }

        // GET: Facturas/Create
        public async Task<IActionResult> Create()
        {
            /**
            * Obtener los productos disponibles para
            * Facturas primer detalle obligatorio
             */
            ViewData["productos"]=await _context.Productos.ToListAsync();
            return View();
        }

        // POST: Facturas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idFactura,NumeroFactura,Fecha,TipodePago,DocumentoCliente,NombreCliente,SubTotal,Descuento,IVA,TotalDescuento,TotalImpuesto,Total")] Facturas facturas,int codigoProducto,int cantidadProducto,int precioProducto)
        {
            if (ModelState.IsValid)
            {
                /**
                * Se crean por defecto en 0 el sub total, total impuesto,
                * total descuento y total.
                * Estos serán actualizados al momento de agregar los detalles
                 */
                facturas.SubTotal=0;
                facturas.TotalDescuento=0;
                facturas.TotalImpuesto=0;
                facturas.Total=0;
                var facturaAgregada=_context.Facturas.Add(facturas);
                await _context.SaveChangesAsync();

                /**
                * Crear primer detalle obligatorio al momento de crear una factura
                 */
                if(await DetallesDao.CrearNuevoDetalles(_context,facturaAgregada.Entity.idFactura,cantidadProducto,precioProducto))
                {
                    return RedirectToAction(nameof(Index));
                }                
            }
            ViewData["productos"]=await _context.Productos.ToListAsync();
            return View(facturas);
        }

        // GET: Facturas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facturas = await _context.Facturas.FindAsync(id);
            if (facturas == null)
            {
                return NotFound();
            }
            return View(facturas);
        }

        // POST: Facturas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idFactura,NumeroFactura,Fecha,TipodePago,DocumentoCliente,NombreCliente,SubTotal,Descuento,IVA,TotalDescuento,TotalImpuesto,Total")] Facturas facturas)
        {
            if (id != facturas.idFactura)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(facturas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FacturasExists(facturas.idFactura))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(facturas);
        }

        // GET: Facturas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facturas = await _context.Facturas
                .FirstOrDefaultAsync(m => m.idFactura == id);
            if (facturas == null)
            {
                return NotFound();
            }

            return View(facturas);
        }

        // POST: Facturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var facturas = await _context.Facturas.Include(f => f.Detalles).Where(f => f.idFactura == id).FirstOrDefaultAsync();
            _context.Facturas.Remove(facturas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FacturasExists(int id)
        {
            return _context.Facturas.Any(e => e.idFactura == id);
        }
    }
}
