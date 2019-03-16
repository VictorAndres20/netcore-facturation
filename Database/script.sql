-- Script de base de datos stdfacturacion
-- SQL Server en Ubuntu 16.04
-- Creado por: Víctor Andrés Pedraza León

-- *******************
-- 1.
-- Crear tablas con sus respectivas
-- llaves primarias y relaciones

-- Tabla Productos
CREATE TABLE Productos(
    idProducto INTEGER IDENTITY(1,1),
    Producto VARCHAR(30) NOT NULL,
    CONSTRAINT productos_pk PRIMARY KEY(idProducto)
);
GO

-- Tabla Facturas
CREATE TABLE Facturas(
    idFactura INTEGER IDENTITY(1,1),
    NumeroFactura INTEGER NOT NULL,
    Fecha DATE NOT NULL,
    TipodePago VARCHAR(30) NOT NULL,
    DocumentoCliente INTEGER NOT NULL,
    NombreCliente VARCHAR(50) NOT NULL,
    Subtotal INTEGER NOT NULL,
    Descuento DECIMAL(5,2) NOT NULL,
    IVA DECIMAL(5,2) NOT NULL,
    TotalDescuento DECIMAL(12,2) NOT NULL,
    TotalImpuesto DECIMAL(12,2) NOT NULL,
    Total DECIMAL(12,2) NOT NULL,
    CONSTRAINT facturas_pk PRIMARY KEY(idFactura)
);
GO

-- Tabla Detalles
CREATE TABLE Detalles(
    idDetalle INTEGER IDENTITY(1,1),
    idFactura INTEGER NOT NULL,
    idProducto INTEGER NOT NULL,
    Cantidad INTEGER NOT NULL,
    PrecioUnitario INTEGER NOT NULL,
    CONSTRAINT detalles_pk PRIMARY KEY(idDetalle),
    CONSTRAINT detalle_factura_fk FOREIGN KEY(idFactura)
    REFERENCES Facturas(idFactura),
    CONSTRAINT detalle_producto_fk FOREIGN KEY(idProducto)
    REFERENCES Productos(idProducto)
);
GO

-- *******************
-- 2.
-- Insertar productos por defecto
INSERT INTO Productos(Producto) VALUES('Camisa'),('Pantalon'),('Zapatos'),('Tenis'),('Falda'),('Blusa');
GO

-- *******************
-- 3.
-- Trigger para la actualización de
-- la factura al momento de agregar
-- un nuevo detalle
CREATE TRIGGER AI_DETALLES ON Detalles
AFTER INSERT
AS
BEGIN
    DECLARE @idFact INTEGER, @cantProd INTEGER, @precUnit INTEGER, @subTotal INTEGER, @iva DECIMAL(5,2),
    @desc DECIMAL(5,2), @totalDesc DECIMAL(12,2), @totalImp DECIMAL(12,2), @parcialImp DECIMAL(12,2);
    SELECT @idFact=INSERTED.idFactura,@cantProd=INSERTED.Cantidad,@precUnit=INSERTED.PrecioUnitario
    FROM INSERTED;
    SELECT @subTotal=Facturas.Subtotal,@desc=Facturas.Descuento,@iva=Facturas.IVA
    FROM Facturas
    WHERE Facturas.idFactura=@idFact;
    SET @subTotal=(@subTotal+(@precUnit*@cantProd));
    SET @totalDesc=((@desc/100)*@subTotal);
    SET @parcialImp=((@iva/100)*@subTotal);
    SET @totalImp=@parcialImp-((@desc/100)*@parcialImp);
    UPDATE Facturas
    SET Subtotal=@subTotal,
        TotalDescuento=@totalDesc,
        TotalImpuesto=@totalImp,
        Total=@subTotal+@totalImp-@totalDesc
    WHERE Facturas.idFactura=@idFact;
END;
GO

-- *******************
-- 4.
-- Agregar facturas del ejercicio
INSERT INTO Facturas(NumeroFactura,Fecha,TipodePago,DocumentoCliente,NombreCliente,Subtotal,Descuento,IVA,TotalDescuento,TotalImpuesto,Total) 
VALUES(1001,'9/12/2018','Contado',80225444,'Juan Perez',0,0,19,0,0,0),
(1002,'10/12/2018','Crédito',80225444,'Pablo Hernández',0,10,19,0,0,0), 
(1003,'11/12/2018','Contado',80225444,'Mario Duarte',0,5,19,0,0,0);
GO

-- *******************
-- 5.
-- Agregar detalles del ejercicio
INSERT INTO Detalles(idFactura,idProducto,Cantidad,PrecioUnitario)
VALUES(1,1,1,50000);
GO

INSERT INTO Detalles(idFactura,idProducto,Cantidad,PrecioUnitario)
VALUES(1,2,2,25000);
GO

INSERT INTO Detalles(idFactura,idProducto,Cantidad,PrecioUnitario)
VALUES(2,3,5,20000);
GO

INSERT INTO Detalles(idFactura,idProducto,Cantidad,PrecioUnitario)
VALUES(2,4,4,25000);
GO

INSERT INTO Detalles(idFactura,idProducto,Cantidad,PrecioUnitario)
VALUES(3,5,1,100000);
GO

INSERT INTO Detalles(idFactura,idProducto,Cantidad,PrecioUnitario)
VALUES(3,6,1,200000);
GO