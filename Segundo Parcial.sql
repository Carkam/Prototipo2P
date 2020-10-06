
CREATE DATABASE sic;
USE sic;
CREATE TABLE bodegas
(
	codigo_bodega VARCHAR(5) PRIMARY KEY,
    nombre_bodega VARCHAR(60),
    estatus_bodega VARCHAR(1)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE lineas
(
	codigo_linea int PRIMARY KEY,
    nombre_linea VARCHAR(60),
    estatus_linea VARCHAR(1)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE marcas
(
	codigo_marca int PRIMARY KEY,
    nombre_marca VARCHAR(60),
    estatus_marca VARCHAR(1)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE productos
(
	codigo_producto int PRIMARY KEY,
    nombre_producto VARCHAR(60),
    codigo_linea int,
    codigo_marca int,
    existencia_producto int,
    estatus_producto tinyint,
    FOREIGN KEY (codigo_linea) REFERENCES lineas(codigo_linea),
    FOREIGN KEY (codigo_marca) REFERENCES marcas(codigo_marca)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE existencias
(
	codigo_bodega VARCHAR(5),
    codigo_producto int,
    saldo_existencia FLOAT(10,2),
    PRIMARY KEY (codigo_bodega, codigo_producto),
	FOREIGN KEY (codigo_bodega) REFERENCES bodegas(codigo_bodega),
    FOREIGN KEY (codigo_producto) REFERENCES productos(codigo_producto)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE vendedores
(
	codigo_vendedor VARCHAR(5) PRIMARY KEY,
    nombre_vendedor VARCHAR(60),
    direccion_vendedor VARCHAR(60),
    telefono_vendedor VARCHAR(50),
    nit_vendedor VARCHAR(20),
    estatus_vendedor VARCHAR(1)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE clientes
(
	codigo_cliente VARCHAR(5) PRIMARY KEY,
    nombre_cliente VARCHAR(60),
    direccion_cliente VARCHAR(60),
    nit_cliente VARCHAR(20),
    telefono_cliente VARCHAR(50),
    estatus_cliente VARCHAR(1)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE proveedores
(
	codigo_proveedor VARCHAR(5) PRIMARY KEY,
    nombre_proveedor VARCHAR(60),
    direccion_proveedor VARCHAR(60),
    telefono_proveedor VARCHAR(50),
    nit_proveedor VARCHAR(50),
    estatus_proveedor VARCHAR(1)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE compras_encabezado
(
	documento_compraenca VARCHAR(10) PRIMARY KEY,
    codigo_proveedor VARCHAR(5),
    fecha_compraenca DATE,
	total_compraenca FLOAT(10,2),
    estatus_compraenca VARCHAR(1),
    FOREIGN KEY (codigo_proveedor) REFERENCES proveedores(codigo_proveedor)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE compras_detalle
(
	documento_compraenca VARCHAR(10),
    codigo_producto int,
    cantidad_compradet FLOAT(10,2),
    costo_compradet FLOAT(10,2),
	codigo_bodega VARCHAR(5),
    PRIMARY KEY (documento_compraenca, codigo_producto),
    FOREIGN KEY (documento_compraenca) REFERENCES compras_encabezado(documento_compraenca),
    FOREIGN KEY (codigo_producto) REFERENCES productos(codigo_producto),
    FOREIGN KEY (codigo_bodega) REFERENCES bodegas(codigo_bodega)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE ventas_encabezado
(
	documento_ventaenca VARCHAR(10) PRIMARY KEY,
    codigo_cliente VARCHAR(5),
    codigo_vendedor VARCHAR(5),
    fecha_ventaenca DATE,
    total_ventaenca FLOAT(10,2),
    estatus_ventaenca VARCHAR(1),
    FOREIGN KEY (codigo_cliente) REFERENCES clientes(codigo_cliente),
    FOREIGN KEY (codigo_vendedor) REFERENCES vendedores(codigo_vendedor)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE ventas_detalle
(
	documento_ventaenca VARCHAR(10),
    codigo_producto int,
    cantidad_ventadet FLOAT(10,2),
    costo_ventadet FLOAT(10,2),
    precio_ventadet FLOAT(10,2),
    codigo_bodega VARCHAR(5),
    PRIMARY KEY (documento_ventaenca, codigo_producto),
    FOREIGN KEY (documento_ventaenca) REFERENCES ventas_encabezado(documento_ventaenca),
    FOREIGN KEY (codigo_producto) REFERENCES productos(codigo_producto),
    FOREIGN KEY (codigo_bodega) REFERENCES bodegas(codigo_bodega)
) ENGINE=INNODB DEFAULT CHARSET=latin1;

insert into marcas values(1,'nike',1);
insert into marcas values(2,'adidas',1);
insert into marcas values(3,'converse',1);
insert into marcas values(4,'sketcher',1);

insert into lineas values (1,'calzado',1);
insert into lineas values (2,'playeras',1);
insert into lineas values (3,'pantalones',1);
insert into lineas values (4,'gorras',1);

select * from productos;
