// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/**
 * Función que valida e interactúa
 * con el formulario de agregar producto obligatorio
 * en el formulario agregar factura
 */
function agregarProducto()
{
    var codigo=document.getElementById("codigoProducto").value;
    var codProducto=document.getElementById("codProducto").value;
    var cantProducto=document.getElementById("cantProducto").value;
    var precProducto=document.getElementById("precProducto").value;
    
    if(cantProducto<=0)
    {
        mostrarAlerta("La cantidad debe ser mayor a 0",0);
    }
    else if(precProducto<0)
    {
        mostrarAlerta("El precio no puede negativo",0);
    }
    else
    {
        if(codigo<=0)
        {
            document.getElementById("mensajeAgregar").className="alert alert-success";
            document.getElementById("btnAgregar").className="btn btn-danger";
            document.getElementById("btnAgregar").innerHTML="Cambiar producto";
            document.getElementById("mensajeAgregar").innerHTML="Producto agregado";
            document.getElementById("btnAgregarFactuta").disabled=false;
        }
        else
        {
            mostrarAlerta("Producto cambiado",1);
            document.getElementById("mensajeAgregar").innerHTML="Producto cambiado";
        }
        /**
         * Actualizar los campos del nuevo producto
         */
        document.getElementById("codigoProducto").value=codProducto;
        document.getElementById("cantidadProducto").value=cantProducto;
        document.getElementById("precioProducto").value=precProducto;
    } 
}

/**
 * Función que valida e interactúa
 * con el formulario de crear nueva factura
 */
function crearFactura()
{
    var formulario=document.getElementById("formularioFactura");
    var codProducto=document.getElementById("codigoProducto").value;
    var cantProducto=document.getElementById("cantidadProducto").value;
    var precProducto=document.getElementById("precioProducto").value;
    var fecha=document.getElementById("fechaFactura").value;
    
    if(cantProducto=="" || precProducto=="")
    {
        mostrarAlerta("Campos Vacios",0)
    }
    else if(codProducto<=0)
    {
        mostrarAlerta("No se ha agregado ningún producto",0)
    }
    else if(cantProducto<=0 || precProducto<=0)
    {
        mostrarAlerta("Valores negativos",0)
    }   
    else if(validarFechaErronea(fecha))
    {
        mostrarAlerta("La fecha debe ser igual o mayor a la de hoy",0)
    } 
    else
    {
        formulario.submit();
    }
}

/**
 * Función para validar que no se
 * agregue un afactura con fecha anteior
 * a la actual.
 * Esta función retornará True si es errónea.
 */
function validarFechaErronea(fecha)
{
    var fechaActual=new Date();
    var fechaArr=fecha.split("-");
    var fechaNueva=new Date(fechaArr[0],fechaArr[1]-1,fechaArr[2],23,59,59,99);
    if(fechaActual.getTime() > fechaNueva.getTime())
    {
        return true;
    } 
    return false;
}

/**
 * Función que valida e interactúa
 * con el formulario de crear un nuevo detalle
 * a una factura
 */
function crearDetalle()
{
    var formulario=document.getElementById("formularioDetalle");
    var codigoFactura=document.getElementById("codFactura").value;
    var codigoProducto=document.getElementById("codProducto").value;
    var precioDetalle=document.getElementById("precDetalle").value;
    var cantidadDetalle=document.getElementById("cantDetalle").value;

    if(precioDetalle=="" || cantidadDetalle=="")
    {
        mostrarAlerta("Campos vacíos",0);
    }
    else if(precioDetalle<0)
    {
        mostrarAlerta("Precio debe ser negativo",0);
    }
    else if(cantidadDetalle<=0)
    {
        mostrarAlerta("Cantidad debe ser mayor a 0",0);
    }
    else
    {
        formulario.submit();
    }
}

/**
 * Función que muestra mensaje de alerta
 * en la parte superior de las vistas.
 */
function mostrarAlerta(msg,tipo)
{
    document.getElementById("mensajeGlobal").style="display: block;visibility:visible";
    if(tipo==1)
    {
        document.getElementById("msgAlerta").innerHTML="Éxito, "+ msg;
        document.getElementById("mensajeGlobal").className="alert alert-success";
    }
    else if(tipo==0)
    {
        document.getElementById("msgAlerta").innerHTML="Error, "+msg;
        document.getElementById("mensajeGlobal").className="alert alert-danger";
    }
    setTimeout(function(){ cerrarAlerta()}, 5000);   
}

/**
 * Función que cierra el mensaje de alerta
 * que aparece en la parte superior de las vistas.
 */
function cerrarAlerta()
{
    document.getElementById("mensajeGlobal").style="display: none;visibility:hidden";
}