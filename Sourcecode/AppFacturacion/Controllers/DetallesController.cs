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
    public class DetallesController : Controller
    {
        private readonly FacturacionContext _context;

        public DetallesController(FacturacionContext context)
        {
            _context = context;
        }

        // GET: Detalles
        public async Task<IActionResult> Index()
        {
            var facturacionContext = _context.Detalles.Include(d => d.Facturas).Include(d => d.Productos);
            return View(await facturacionContext.ToListAsync());
        }

        // GET: Detalles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalles = await _context.Detalles
                .Include(d => d.Facturas)
                .Include(d => d.Productos)
                .FirstOrDefaultAsync(m => m.idDetalle == id);
            if (detalles == null)
            {
                return NotFound();
            }

            return View(detalles);
        }

        // GET: Detalles/Create
        /**
        * Crear un detalle a una factura.
        * Método HTTP GET para cargar formulario.
        * @param id - Código de la factura a la cual se le crea el detalle
         */
        public IActionResult Create(int id=0)
        {
            /**
            * Codigo de factura a agregar detalle
             */
            ViewData["codFactura"]=id;
            /**
            * Productos disponibles
             */
            ViewData["idProducto"] = new SelectList(_context.Productos, "idProducto", "Producto");
            return View();
        }

        // POST: Detalles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        /**
        * Crear detalle a factura en especial
        * método HTTP POST para crear el detalle
        * 
         */
        [HttpPost]
        public async Task<IActionResult> Create(int codigoFactura,int codigoProducto, int cantidadDetalle,int precioDetalle)
        {            
            Detalles detalle=new Detalles();
            detalle.idFactura=codigoFactura;
            detalle.idProducto=codigoProducto;
            detalle.Cantidad=cantidadDetalle;
            detalle.PrecioUnitario=precioDetalle;
            _context.Add(detalle);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index","Facturas");
        }

        // GET: Detalles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalles = await _context.Detalles.FindAsync(id);
            if (detalles == null)
            {
                return NotFound();
            }
            ViewData["idFactura"] = new SelectList(_context.Facturas, "idFactura", "NombreCliente", detalles.idFactura);
            ViewData["idProducto"] = new SelectList(_context.Productos, "idProducto", "Producto", detalles.idProducto);
            return View(detalles);
        }

        // POST: Detalles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idDetalle,idFactura,idProducto,Cantidad,PrecioUnitario")] Detalles detalles)
        {
            if (id != detalles.idDetalle)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detalles);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetallesExists(detalles.idDetalle))
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
            ViewData["idFactura"] = new SelectList(_context.Facturas, "idFactura", "NombreCliente", detalles.idFactura);
            ViewData["idProducto"] = new SelectList(_context.Productos, "idProducto", "Producto", detalles.idProducto);
            return View(detalles);
        }

        // GET: Detalles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalles = await _context.Detalles
                .Include(d => d.Facturas)
                .Include(d => d.Productos)
                .FirstOrDefaultAsync(m => m.idDetalle == id);
            if (detalles == null)
            {
                return NotFound();
            }

            return View(detalles);
        }

        // POST: Detalles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detalles = await _context.Detalles.FindAsync(id);
            _context.Detalles.Remove(detalles);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetallesExists(int id)
        {
            return _context.Detalles.Any(e => e.idDetalle == id);
        }
    }
}
