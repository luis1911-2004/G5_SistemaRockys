


create database GRupo05_Rokys
use GRupo05_Rokys
go


CREATE TABLE TipoInsumos (
    TipoInsumoID INT PRIMARY KEY,
    NombreTipo VARCHAR(100) NOT NULL,
    UnidadDeMedida VARCHAR(50)
);
GO

CREATE TABLE FormaDePago (
    FormaDePagoID INT PRIMARY KEY,
    NombreForma VARCHAR(100) NOT NULL,
    Descripcion VARCHAR(255)
);
GO

CREATE TABLE Proveedor (
    ProveedorID INT IDENTITY(1,1) PRIMARY KEY,
    NombreProveedor NVARCHAR(150) NOT NULL, 
    RUC CHAR(11) NOT NULL UNIQUE,
    TelefonoProvee VARCHAR(9),
    CiudadProvee NVARCHAR(50),
    DireccionProvee NVARCHAR(150),
    Rubro NVARCHAR(50)
);
GO

CREATE TABLE Requerimiento (
    RequerimientoID INT IDENTITY(1,1) PRIMARY KEY,
    Descripcion NVARCHAR(200) NOT NULL,
    EstadoDeRequerimiento NVARCHAR(20) DEFAULT 'PENDIENTE'
);
GO


CREATE TABLE OrdenDeCompra (
    OrdenDeCompraID INT IDENTITY(1,1) PRIMARY KEY,
    ProveedorID INT NOT NULL,
    RequerimientoID INT NOT NULL UNIQUE, 
    Fecha DATE NOT NULL,
    EstadoOrden NVARCHAR(20) DEFAULT 'PENDIENTE',

    CONSTRAINT FK_Orden_Proveedor
        FOREIGN KEY (ProveedorID)
        REFERENCES Proveedor(ProveedorID),

    CONSTRAINT FK_Orden_Requerimiento
        FOREIGN KEY (RequerimientoID)
        REFERENCES Requerimiento(RequerimientoID)
);
GO


CREATE TABLE DetalleVenta (
    DetalleVentaID INT PRIMARY KEY,
    FormaDePagoID INT NOT NULL,
    MontoTotal DECIMAL(10, 2) NOT NULL,
    
    CONSTRAINT FK_DetalleVenta_FormaDePago FOREIGN KEY (FormaDePagoID) REFERENCES FormaDePago(FormaDePagoID)
);
GO


CREATE TABLE Inventario (
    InventarioID INT PRIMARY KEY,
    Cantidad INT NOT NULL 
);
GO


CREATE TABLE Insumos (
    InsumoID INT PRIMARY KEY, 
    NombreInsumo VARCHAR(255) NOT NULL,
    Cantidad INT NOT NULL,
    
    TipoInsumoID INT NOT NULL, 

    ProveedorID INT NOT NULL,

    NotaDeIngresoID INT, 

    CONSTRAINT FK_Insumos_TipoInsumos FOREIGN KEY (TipoInsumoID) REFERENCES TipoInsumos(TipoInsumoID),
    CONSTRAINT FK_Insumos_Proveedor FOREIGN KEY (ProveedorID) REFERENCES Proveedor(ProveedorID)
);
GO

ALTER TABLE Inventario
ADD InsumoID INT UNIQUE NOT NULL, 
    CONSTRAINT FK_Inventario_Insumos FOREIGN KEY (InsumoID) REFERENCES Insumos(InsumoID);
GO


CREATE TABLE NotaIngreso (
    NotaDeIngresoID INT PRIMARY KEY, 
    Fecha DATE NOT NULL, 
    Observacion VARCHAR(255), 
    
    OrdenCompraID INT UNIQUE NOT NULL, 
    InventarioID INT UNIQUE NOT NULL, 

    CONSTRAINT FK_NotaIngreso_OrdenCompra FOREIGN KEY (OrdenCompraID) REFERENCES OrdenDeCompra(OrdenDeCompraID),
    CONSTRAINT FK_NotaIngreso_Inventario FOREIGN KEY (InventarioID) REFERENCES Inventario(InventarioID)
);
GO

ALTER TABLE Insumos
ADD CONSTRAINT FK_Insumos_NotaIngreso FOREIGN KEY (NotaDeIngresoID) REFERENCES NotaIngreso(NotaDeIngresoID);
GO


CREATE TABLE RegistroDeRetiro (
    RetiroID INT PRIMARY KEY, 
    AlmacenID INT NOT NULL, 
    Fecha DATE NOT NULL, 
    Cantidad INT NOT NULL, 
    
    InventarioID INT NOT NULL,
    
    CONSTRAINT FK_RegistroDeRetiro_Inventario FOREIGN KEY (InventarioID) REFERENCES Inventario(InventarioID)
);
GO


CREATE TABLE Pedido (
    PedidoID INT PRIMARY KEY,
    FechaPedido DATE NOT NULL,
    CantidadPedida INT NOT NULL,
    
    InsumoID INT NOT NULL,
    DetalleVentaID INT NOT NULL,

    CONSTRAINT FK_Pedido_Insumos FOREIGN KEY (InsumoID) REFERENCES Insumos(InsumoID),
    CONSTRAINT FK_Pedido_DetalleVenta FOREIGN KEY (DetalleVentaID) REFERENCES DetalleVenta(DetalleVentaID)
);
GO


CREATE TABLE RegistroNoConformidad (
    RegistroNCID INT PRIMARY KEY,
    Descripcion VARCHAR(255) NOT NULL,
    FechaRegistro DATE NOT NULL,
    
    RetiroID INT UNIQUE NOT NULL,

    CONSTRAINT FK_RegistroNC_RegistroDeRetiro FOREIGN KEY (RetiroID) REFERENCES RegistroDeRetiro(RetiroID)
);
GO

CREATE TABLE Reclamo (
    ReclamoID INT PRIMARY KEY,
    Descripcion VARCHAR(255) NOT NULL,
    FechaReclamo DATE NOT NULL,
    Estado VARCHAR(50),
    
    PedidoID INT NOT NULL,

    CONSTRAINT FK_Reclamo_Pedido FOREIGN KEY (PedidoID) REFERENCES Pedido(PedidoID)
);
GO

CREATE TABLE AlertaDeRetraso (
    AlertaID INT PRIMARY KEY,
    Descripcion VARCHAR(255) NOT NULL,
    FechaAlerta DATETIME NOT NULL,
    
    PedidoID INT, 
    
    CONSTRAINT FK_AlertaDeRetraso_Pedido FOREIGN KEY (PedidoID) REFERENCES Pedido(PedidoID)
);
GO


CREATE TABLE RegistroFallas (
    FallaID INT PRIMARY KEY,
    DescripcionFalla VARCHAR(255) NOT NULL,
    FechaFalla DATE NOT NULL,
    
    AlertaID INT UNIQUE NOT NULL, 
    
    CONSTRAINT FK_RegistroFallas_AlertaDeRetraso FOREIGN KEY (AlertaID) REFERENCES AlertaDeRetraso(AlertaID)
);
GO


CREATE TABLE SolicitudInsumosExtra (
    SolicitudExtraID INT PRIMARY KEY,
    CantidadSolicitada INT NOT NULL,
    Motivo VARCHAR(255),
    FechaSolicitud DATE NOT NULL,
    
    AlertaDeRetrasoID INT NOT NULL, 

    CONSTRAINT FK_SolicitudExtra_AlertaDeRetraso FOREIGN KEY (AlertaDeRetrasoID) REFERENCES AlertaDeRetraso(AlertaID)
);
GO

CREATE PROCEDURE spInsertarProveedor
(
    @NombreProveedor NVARCHAR(150), 
    @RUC CHAR(11),
    @TelefonoProvee VARCHAR(9),
    @CiudadProvee NVARCHAR(50),
    @DireccionProvee NVARCHAR(150),
    @Rubro NVARCHAR(50)
)
AS
BEGIN
    INSERT INTO Proveedor (NombreProveedor, RUC, TelefonoProvee, CiudadProvee, DireccionProvee, Rubro)
    VALUES (@NombreProveedor, @RUC, @TelefonoProvee, @CiudadProvee, @DireccionProvee, @Rubro);
END
GO

CREATE PROCEDURE spListarProveedor
AS
BEGIN
    SELECT 
        ProveedorID, 
        NombreProveedor,
        RUC, 
        TelefonoProvee, 
        CiudadProvee, 
        DireccionProvee, 
        Rubro
    FROM 
        Proveedor;
END
GO

CREATE PROCEDURE spEditarProveedor
(
    @ProveedorID INT,
    @NombreProveedor NVARCHAR(150),
    @RUC CHAR(11),
    @TelefonoProvee VARCHAR(9),
    @CiudadProvee NVARCHAR(50),
    @DireccionProvee NVARCHAR(150),
    @Rubro NVARCHAR(50)
)
AS
BEGIN
    UPDATE Proveedor 
    SET 
        NombreProveedor = @NombreProveedor,
        RUC = @RUC,
        TelefonoProvee = @TelefonoProvee,
        CiudadProvee = @CiudadProvee,
        DireccionProvee = @DireccionProvee,
        Rubro = @Rubro
    WHERE 
        ProveedorID = @ProveedorID;
END
GO

select * from Proveedor

CREATE PROCEDURE spEliminarProveedor
(
    @ProveedorID INT
)
AS
BEGIN
    DELETE FROM Proveedor 
    WHERE ProveedorID = @ProveedorID;
END
GO
select * from OrdenDeCompra