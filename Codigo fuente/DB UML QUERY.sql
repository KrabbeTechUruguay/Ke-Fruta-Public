
###################################
#       CREACION DE TABLAS        #
###################################

#create database ninzua;
use ninzua;

DROP TABLE IF EXISTS Emite CASCADE;
DROP TABLE IF EXISTS Factura CASCADE;
DROP TABLE IF EXISTS Compra CASCADE;
DROP TABLE IF EXISTS Producto CASCADE;
DROP TABLE IF EXISTS Insumo CASCADE;
DROP TABLE IF EXISTS Item CASCADE;
DROP TABLE IF EXISTS Fertilizacion CASCADE;
DROP TABLE IF EXISTS Evento CASCADE;
DROP TABLE IF EXISTS Sector CASCADE;
DROP TABLE IF EXISTS Predio CASCADE;
DROP TABLE IF EXISTS Productor CASCADE;
DROP TABLE IF EXISTS Administrativo CASCADE;
DROP TABLE IF EXISTS Telefono CASCADE;
DROP TABLE IF EXISTS Usuario CASCADE;

CREATE TABLE IF NOT EXISTS Usuario (
    ci CHAR(8) NOT NULL UNIQUE,
    nom_a VARCHAR(20) NOT NULL,
    nom_b VARCHAR(20),
    ape_a VARCHAR(35) NOT NULL,
    ape_b VARCHAR(35) NOT NULL,
    mail VARCHAR(35) NOT NULL UNIQUE,
    user VARCHAR(35) NOT NULL UNIQUE,
    pass CHAR(32) NOT NULL, #HASH MD5 128bit
    calle_a VARCHAR(35),
    calle_b VARCHAR(35),
    nro_puerta VARCHAR(5),
    baja BOOL DEFAULT FALSE,
    PRIMARY KEY (ci)
);
 
CREATE TABLE IF NOT EXISTS Telefono (
    ci CHAR(8) NOT NULL,
    tel VARCHAR(15) NOT NULL,
    PRIMARY KEY (ci, tel),
    UNIQUE KEY `CI_Telefono` (ci, tel),
    CONSTRAINT FK_UsuarioTelefono FOREIGN KEY (ci)
        REFERENCES Usuario (ci) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Administrativo (
    ci CHAR(8) NOT NULL UNIQUE,
    cargo VARCHAR(12) NOT NULL,
    PRIMARY KEY (ci),
    CONSTRAINT FK_UsuarioAdministrativo FOREIGN KEY (ci)
        REFERENCES Usuario (ci) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Productor (
    ci CHAR(8) NOT NULL UNIQUE,
    rut_prod CHAR(12),
    produce CHAR(3) NOT NULL CHECK (produce = 'CER' OR produce = 'FRU' OR produce = 'VER'),
    PRIMARY KEY (ci),
    CONSTRAINT FK_UsuarioProductor FOREIGN KEY (ci)
        REFERENCES Usuario (ci) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Predio (
    id_pred INT UNSIGNED NOT NULL AUTO_INCREMENT UNIQUE,
    ci_prod CHAR(8),
    nom_pred VARCHAR(25) NOT NULL UNIQUE,
    hect_pred INT UNSIGNED NOT NULL,
    ub_pred VARCHAR(50),
    PRIMARY KEY (id_pred),
    CONSTRAINT FK_ProductorPredio FOREIGN KEY (ci_prod)
        REFERENCES Productor (ci) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Sector (
    id_sect SMALLINT UNSIGNED NOT NULL,
    id_pred INT UNSIGNED NOT NULL,
    ci_prod CHAR(8),
    nom_sect VARCHAR(25),
    hect_sect INT UNSIGNED NOT NULL,
    ub_sect VARCHAR(50),
    estado_sect CHAR(4) NOT NULL DEFAULT 'DISP' CHECK (estado_sect = 'DISP' OR estado_sect = 'DESC' OR estado_sect = 'OCUP'),
    PRIMARY KEY (id_sect , id_pred),
    UNIQUE KEY `ID_Sector` (id_sect , id_pred),
    UNIQUE KEY `NOM_Sector` (id_pred , nom_sect),
    CONSTRAINT FK_ID_SectorPredio FOREIGN KEY (id_pred)
        REFERENCES Predio (id_pred) ON DELETE CASCADE,
    CONSTRAINT FK_CI_SectorPredio FOREIGN KEY (ci_prod)
        REFERENCES Predio (ci_prod) ON DELETE CASCADE 
);

CREATE TABLE IF NOT EXISTS Evento ( 
    id_event INT UNSIGNED NOT NULL AUTO_INCREMENT UNIQUE,
    id_sect SMALLINT UNSIGNED NOT NULL,
    id_pred INT UNSIGNED NOT NULL,
    tipo_event CHAR(4) NOT NULL DEFAULT 'SIEM' CHECK (tipo_event = 'SIEM' OR tipo_event = 'COSE' OR tipo_event = 'DESC'),
    ci_prod CHAR(8) NOT NULL,
    f_ini DATE NOT NULL,
    f_fin DATE NOT NULL,
    cat_prod CHAR(3) NOT NULL CHECK (cat_prod = 'CER' OR cat_prod = 'FRU' OR cat_prod = 'VER'),
    tipo_prod VARCHAR(12) NOT NULL CHECK (tipo_prod = 'TRIGO' OR tipo_prod = 'CEBADA' OR tipo_prod = 'MANZANA' OR tipo_prod = 'NARANJA' OR tipo_prod = 'LIMON' OR tipo_prod = 'PAPA ROSADA' OR tipo_prod = 'ZAPALLO CRI'),
    info_event TINYTEXT,
    ci_admin CHAR(8),
    f_gest TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP, 
    estado_event CHAR(4) NOT NULL DEFAULT 'PEND' CHECK (estado_event = 'CONF' OR estado_event = 'CANC' OR estado_event = 'PEND'),
    id_event_ant INT UNSIGNED,
    PRIMARY KEY (id_event),
    UNIQUE KEY `ID_Evento` (id_event , id_sect , f_ini , f_fin),
    CONSTRAINT FK_ID_EventoSector FOREIGN KEY (id_sect)
        REFERENCES Sector (id_sect) ON DELETE CASCADE,
    CONSTRAINT FK_PRED_EventoPredio FOREIGN KEY (id_pred)
        REFERENCES Sector (id_pred) ON DELETE CASCADE,
    CONSTRAINT FK_CI_ProductorEvento FOREIGN KEY (ci_prod)
        REFERENCES Productor (ci) ON DELETE CASCADE ,
    CONSTRAINT FK_CI_AdministrativoEvento FOREIGN KEY (ci_admin)
        REFERENCES Administrativo (ci) ON DELETE CASCADE ,
    CONSTRAINT FK_ID_AnteriorEvento FOREIGN KEY (id_event_ant)
        REFERENCES Evento (id_event) ON DELETE CASCADE,
	CONSTRAINT CHK_DateEvento CHECK (f_fin > f_ini)
);

CREATE TABLE IF NOT EXISTS Fertilizacion (
    id_fert INT UNSIGNED NOT NULL AUTO_INCREMENT UNIQUE,
    id_event INT UNSIGNED NOT NULL,
    fecha DATE NOT NULL,
    estadio_z DECIMAL(2 , 1 ),
    fosforo_sue DECIMAL(15 , 3 ),
    nitrato_sue DECIMAL(15 , 3 ),
    nitrog_sue DECIMAL(15 , 3 ),
    nitrog_pla DECIMAL(15 , 3 ),
    nivel_crit DECIMAL(15 , 3 ) NOT NULL,
    equiv_fert DECIMAL(15 , 3 ) NOT NULL,
    PRIMARY KEY (id_fert),
    UNIQUE KEY `ID_Fertilizacion` (id_fert , id_event),
    CONSTRAINT FK_ID_EventoFertilizacion FOREIGN KEY (id_event)
        REFERENCES Evento (id_event) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Item (
    cod_item INT UNSIGNED NOT NULL AUTO_INCREMENT UNIQUE,
    peso DECIMAL(10 , 2 ) NOT NULL CHECK (peso > 0),
    nom_item VARCHAR(20) NOT NULL,
    descr TINYTEXT,
    cant SMALLINT UNSIGNED DEFAULT 1,
    precio DECIMAL(20 , 4 ) NOT NULL CHECK (precio > 0),
    baja BOOL DEFAULT FALSE,
    PRIMARY KEY (cod_item)
);

CREATE TABLE IF NOT EXISTS Producto (
    cod_item INT UNSIGNED NOT NULL AUTO_INCREMENT UNIQUE,
    cat_prod CHAR(3) NOT NULL CHECK (cat_prod = 'CER' OR cat_prod = 'FRU' OR cat_prod = 'VER'),
    tipo_prod VARCHAR(12) NOT NULL CHECK (tipo_prod = 'TRIGO' OR tipo_prod = 'CEBADA' OR tipo_prod = 'MANZANA' OR tipo_prod = 'NARANJA' OR tipo_prod = 'LIMON' OR tipo_prod = 'PAPA ROSADA' OR tipo_prod = 'ZAPALLO CRI'),
    ci_prod CHAR(8) NOT NULL,
    id_event INT UNSIGNED NOT NULL,
    f_cosecha DATE,
    PRIMARY KEY (cod_item),
    CONSTRAINT FK_COD_ItemProducto FOREIGN KEY (cod_item)
        REFERENCES Item (cod_item) ON DELETE CASCADE,
    CONSTRAINT FK_CI_EventoProducto FOREIGN KEY (ci_prod)
        REFERENCES Productor (ci) ON DELETE CASCADE,
	CONSTRAINT FK_ID_EventoProducto FOREIGN KEY (id_event)
		REFERENCES Evento (id_event) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Insumo (
    cod_item INT UNSIGNED NOT NULL AUTO_INCREMENT UNIQUE,
    cat_ins CHAR(4) NOT NULL CHECK (cat_ins = 'SEMI' OR cat_ins = 'PLAN' OR cat_ins = 'HERB' OR cat_ins = 'FUNG' OR cat_ins = 'INSE' OR cat_ins = 'FERT' OR cat_ins = 'OTRO'),
    tipo_ins VARCHAR(12) NOT NULL DEFAULT 'OTRO' CHECK (tipo_ins = 'TRIGO' OR tipo_ins = 'CEBADA' OR tipo_ins = 'NITROGENO' OR tipo_ins = 'FOSFORO' OR tipo_ins = 'OTRO'), #Si no es fertilizante es de tipo OTRO
    PRIMARY KEY (cod_item),
    CONSTRAINT FK_COD_ItemInsumo FOREIGN KEY (cod_item)
        REFERENCES Item (cod_item) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Compra (
    cod_comp INT UNSIGNED NOT NULL AUTO_INCREMENT UNIQUE,
    ci_cliente CHAR(8) NOT NULL,
    f_comp TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP, 
    cod_item INT UNSIGNED NOT NULL,
    cant SMALLINT UNSIGNED NOT NULL DEFAULT 1,
    ci_admin CHAR(8), 
    f_confir DATETIME, 
    PRIMARY KEY (cod_comp),
    UNIQUE KEY `ID_Compra` (ci_cliente, f_comp, cod_item),
    CONSTRAINT FK_COD_ItemCompra FOREIGN KEY (cod_item)
        REFERENCES Item (cod_item) ON DELETE CASCADE,
    CONSTRAINT FK_COD_ClienteCompra FOREIGN KEY (ci_cliente)
        REFERENCES Productor (ci) ON DELETE CASCADE,
    CONSTRAINT FK_CI_AdministrativoCompra FOREIGN KEY (ci_admin)
        REFERENCES Administrativo (ci) ON DELETE CASCADE,
	CONSTRAINT CHK_FechaCompra CHECK (f_confir > f_comp)
);

CREATE TABLE IF NOT EXISTS Factura (
    cod_fact INT UNSIGNED NOT NULL AUTO_INCREMENT UNIQUE,
    tipo_fact CHAR(9) NOT NULL DEFAULT 'CONTADO' CHECK (tipo_fact = 'CONTADO' OR tipo_fact = 'CREDITO' OR tipo_fact = 'N.CREDITO' OR tipo_fact = 'R.OFICIAL'),
    rut_fact CHAR(12),
    costo DECIMAL(20 , 4 ) NOT NULL, 
    iva DECIMAL(4 , 2 ) NOT NULL DEFAULT 22.0, 
    total DECIMAL(20 , 4 ) NOT NULL, 
    PRIMARY KEY (cod_fact, tipo_fact),
    UNIQUE KEY `ID_Factura` (cod_fact, tipo_fact)
);

CREATE TABLE IF NOT EXISTS Emite (
    cod_fact INT UNSIGNED NOT NULL, 
    tipo_fact CHAR(9) NOT NULL CHECK (tipo_fact = 'CONTADO' OR tipo_fact = 'CREDITO' OR tipo_fact = 'N.CREDITO' OR tipo_fact = 'R.OFICIAL'),
    cod_comp INT UNSIGNED NOT NULL AUTO_INCREMENT,
    f_emite TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP, 
    PRIMARY KEY (cod_fact, tipo_fact, cod_comp),
    UNIQUE KEY `ID_EmiteFactura` (cod_fact, tipo_fact, cod_comp),
    CONSTRAINT FK_COD_TIPO_FacturaEmite FOREIGN KEY (cod_fact, tipo_fact)
        REFERENCES Factura (cod_fact, tipo_fact) ON DELETE CASCADE,
    CONSTRAINT FK_COD_CompraEmite FOREIGN KEY (cod_comp)
        REFERENCES Compra (cod_comp) ON DELETE CASCADE
);



###################################
#    INSERTS PARA DB (POPULATE)   #
###################################

INSERT INTO Usuario VALUES(50706831, 'Mauro', NULL, 'Rodriguez', 'Rocha', 'marutioh@mail.com', 'Maurito', 'gdyb21LQTcIANtvYMT7QVQ==', 'Acevedo diaz', 'Ponte', '1234', false);
INSERT INTO Usuario VALUES(31508234, 'Juan', NULL, 'Carlos', 'Garcia', 'juan@mail.com', 'JuanCarlos', 'gdyb21LQTcIANtvYMT7QVQ==', 'Montero Vidaurreta', 'Requena', '453', false);
INSERT INTO Usuario VALUES(40906348, 'Jose', 'Luis', 'Gianneo', 'Aquelarre', 'jaquelarre@mail.com', 'jaquelarre', 'gdyb21LQTcIANtvYMT7QVQ==', 'Luis de la peña', 'Bauzá', '584', false);
INSERT INTO Usuario VALUES(76524566, 'Lorenzo', null, 'Almagro', 'Spuntote', 'almas@mail.com', 'l.almagro', 'gdyb21LQTcIANtvYMT7QVQ==', 'Benito requena', null, '234', false);
INSERT INTO Usuario VALUES(32534646, 'Jose', 'Gilverto', 'Almagro', 'Chinchun', 'sdadada@mail.com', 'jgilvert', 'gdyb21LQTcIANtvYMT7QVQ==', 'Luis de la peña', null, '534', false);
INSERT INTO Usuario VALUES(45346345, 'Alberto', 'Andres', 'Mutter', 'Alberti', 'asdasd@mail.com', 'albertan', 'gdyb21LQTcIANtvYMT7QVQ==', 'Varela',  null, '323', false);
INSERT INTO Usuario VALUES(56734466, 'Juan', 'Agustin', 'Gianni', 'Prodan', 'asdasf@mail.com', 'JAgustin', 'gdyb21LQTcIANtvYMT7QVQ==', 'Artigas',  null, '736', false); # NO INGRESARLE NINGUN ROL, ES USUARIO DE PRUEBA SIN ROL
INSERT INTO Usuario VALUES(54645655, 'Carlos', 'Pedro', 'Retamoso', 'Luca', 'dsfsfsf@mail.com', 'carlosp', 'gdyb21LQTcIANtvYMT7QVQ==', 'Paysandu',  null, '4573', false);
INSERT INTO Usuario VALUES(23436644, 'Ruiz', 'Pablo', 'Morrone', 'Luna', 'edasds@mail.com', 'pmarrone', 'gdyb21LQTcIANtvYMT7QVQ==', 'Yaguaron',  null, '4756', false);
INSERT INTO Usuario VALUES(54754956, 'Jose', 'Pepe', 'Marrone', 'Ann', 'sdsdaf@mail.com', 'jann123', 'gdyb21LQTcIANtvYMT7QVQ==', 'Cerrito',  null, '3554', false);
INSERT INTO Usuario VALUES(56474566, 'Alba', 'Juan', 'Mutt', 'Sulma', 'sdfsdffdf@mail.com', 'albamutt', 'gdyb21LQTcIANtvYMT7QVQ==', 'Amezaga',  null, '452', false);
INSERT INTO Usuario VALUES(52374566, 'Alberto', 'Gean', 'Rivera', 'Falu', 'asdddd@mail.com', 'AlbertoGean', 'gdyb21LQTcIANtvYMT7QVQ==', 'Tacuabe',  null, '3452', true); # DADO DE BAJA
INSERT INTO Usuario VALUES(51234566, 'Daniel', 'Pedro', 'Damasco', 'Roberti', 'asdasdf@mail.com', 'DaniRob', 'gdyb21LQTcIANtvYMT7QVQ==', 'Cerro Largo',  null, '789', false);
INSERT INTO Usuario VALUES(48390685, 'Donatelo' , 'Josua', 'Damele', 'Rodriali', 'Donatelo2002@mail.com', 'DonaRod', 'gdyb21LQTcIANtvYMT7QVQ==', 'Cerro Chato',null, '5234', false);
INSERT INTO Usuario VALUES(54553267, 'Josepe', 'Randi', 'Copete', 'Barriales', 'JosepeRandiMatrix@mail.com', 'JoseRad', 'gdyb21LQTcIANtvYMT7QVQ==', 'Barriales',null, '863', false);
INSERT INTO Usuario VALUES(47548385, 'Roberto', 'Pepote', 'Consiti', 'Anashe', 'RobertoAnashe@mail.com', 'RobePepo', 'gdyb21LQTcIANtvYMT7QVQ==', 'Banquilla', null, '435', false);
INSERT INTO Usuario VALUES(56346265, 'Robinson', 'Parsin', 'Constantinopla', 'Fachini', 'RobinsonFachini1890@mail.com', 'RobiFachi', 'gdyb21LQTcIANtvYMT7QVQ==', 'Faradai', null, '345', false);
INSERT INTO Usuario VALUES(47834945, 'Mario', 'Panda', 'Fetuchini', 'Ravioli', 'MarioFetuchini20@mail.com', 'MarioFetu', 'gdyb21LQTcIANtvYMT7QVQ==', 'fernandini', null, '6745', false);

INSERT INTO Telefono VALUES(50706831, '099144568');
INSERT INTO Telefono VALUES(50706831, '23094563');
INSERT INTO Telefono VALUES(76524566, '23076576');
INSERT INTO Telefono VALUES(54645655, '23073476');
INSERT INTO Telefono VALUES(31508234, '23845676');
INSERT INTO Telefono VALUES(56474566, '099158348');
INSERT INTO Telefono VALUES(56474566, '098658052');
INSERT INTO Telefono VALUES(48390685, '093945354');
INSERT INTO Telefono VALUES(54553267, '093542356');
INSERT INTO Telefono VALUES(54553267, '234456432');

INSERT INTO Administrativo VALUES(50706831, 'Funcionario');
INSERT INTO Administrativo VALUES(31508234, 'Funcionario');
INSERT INTO Administrativo VALUES(40906348, 'Funcionario');
INSERT INTO Administrativo VALUES(76524566, 'Ayudante');
INSERT INTO Administrativo VALUES(32534646, 'Cajero');
INSERT INTO Administrativo VALUES(45346345, 'Funcionario');

# SON CI, RUT, TIPO_PROD
INSERT INTO Productor VALUES(50706831, '123456789112', 'FRU');
INSERT INTO Productor VALUES(52374566, '123451234112', 'FRU');
INSERT INTO Productor VALUES(51234566, '450973234112', 'CER');
INSERT INTO Productor VALUES(23436644, '347627346284', 'FRU');
INSERT INTO Productor VALUES(48390685, '712389509683', 'VER');
INSERT INTO Productor VALUES(54553267, '781247887544', 'CER');
INSERT INTO Productor VALUES(47548385, '187234785655', 'VER');
INSERT INTO Productor VALUES(56346265, '278347824587', 'VER');
INSERT INTO Productor VALUES(47834945, '782457862456', 'CER');

# PREDIOS SIN USUARIO, OJO ID 2 Y 3 ESTAN USADAS MAS ABAJO
INSERT INTO Predio(id_pred, nom_pred, hect_pred, ub_pred) VALUES(1, 'El naghual', 30, 'https://goo.gl/maps/JHD7H3IUDHD2932');
INSERT INTO Predio(id_pred, ci_prod, nom_pred, hect_pred, ub_pred) VALUES(2, 50706831, 'La Chacrita', 750, 'https://goo.gl/maps/fNEXFqN3EyoSQVHTA');
INSERT INTO Predio(id_pred, ci_prod, nom_pred, hect_pred, ub_pred) VALUES(3, 52374566, 'El carro', 500, 'https://goo.gl/maps/fNAas2d29D1QVHTA');
INSERT INTO Predio(id_pred, nom_pred, hect_pred, ub_pred) VALUES(4, 'Las brujas', 20, 'https://goo.gl/maps/JHqf34g3gr3HD2932');
INSERT INTO Predio(id_pred, nom_pred, hect_pred, ub_pred) VALUES(5, 'Pajonal', 10, 'https://goo.gl/maps/J44rrr22DHD2932');
INSERT INTO Predio(id_pred, nom_pred, hect_pred, ub_pred) VALUES(6, 'EL gauchito', 5, 'https://goo.gl/maps/erg3KUYG876FG');
INSERT INTO Predio(id_pred, ci_prod, nom_pred, hect_pred, ub_pred) VALUES(7, 23436644, 'Garra charrua', 200, 'https://goo.gl/maps/JBHqqwe21412DS33');
INSERT INTO Predio(id_pred, ci_prod, nom_pred, hect_pred, ub_pred) VALUES(8, 48390685, 'Golazo', 15, 'https://goo.gl/maps/JFfsdakD232345');
INSERT INTO Predio(id_pred, ci_prod, nom_pred, hect_pred, ub_pred) VALUES(9, 54553267, 'Maracanazo', 45, 'https://goo.gl/maps/SAJKFsdnv23556');
INSERT INTO Predio(id_pred, ci_prod, nom_pred, hect_pred, ub_pred) VALUES(10, 47548385, 'Pibardos', 30, 'https://goo.gl/maps/AScjsADsdfda2069');
INSERT INTO Predio(id_pred, ci_prod, nom_pred, hect_pred, ub_pred) VALUES(11, 56346265, 'Picanteada', 60, 'https://goo.gl/maps/CAsjxDS423566');
INSERT INTO Predio(id_pred, ci_prod, nom_pred, hect_pred, ub_pred) VALUES(12, 50706831, 'La pradera', 100, 'https://goo.gl/maps/asd2fr23r2yoSQVHTA');
INSERT INTO Predio(id_pred, ci_prod, nom_pred, hect_pred, ub_pred) VALUES(13, 52374566, 'Pozuelo', 60, 'https://goo.gl/maps/asdsd2d22dTA');

# SECTORES:
INSERT INTO Sector(id_pred, id_sect, nom_sect, hect_sect, ub_sect, estado_sect) VALUES(1, 1, 'zona uno', 10, 'Montevideo', 'DISP');
INSERT INTO Sector(id_pred, id_sect, nom_sect, hect_sect, ub_sect, estado_sect) VALUES(1, 2, 'zona dos', 10, 'Montevideo', 'DISP');
INSERT INTO Sector(id_pred, id_sect, nom_sect, hect_sect, ub_sect, estado_sect) VALUES(1, 3, 'zona tres', 10, 'Montevideo', 'DISP');
INSERT INTO Sector VALUES(1, 2, 50706831, 'Norte', 150, 'https://goo.gl/maps/fNEXFqN3EyoSQVHTA', 'DESC');
INSERT INTO Sector VALUES(2, 2, 50706831, 'Sur', 150, 'https://goo.gl/maps/fNEXF34TD43FF4VHTA', 'DISP');
INSERT INTO Sector VALUES(3, 2, 50706831, 'Este', 150, 'https://goo.gl/maps/fNEXFFGHF444yoSQVHTA', 'OCUP');
INSERT INTO Sector VALUES(4, 2, 50706831, 'Noreste', 150, 'https://goo.gl/maps/fNEXFqN45G4G4GSQVHTA', 'OCUP');
INSERT INTO Sector VALUES(5, 2, 50706831, 'Sureste', 150, 'https://goo.gl/maps/fNEXFqN45GG5G5GVHTA', 'DISP');
INSERT INTO Sector VALUES(1, 3, 52374566, 'Norte', 100, 'https://goo.gl/maps/fNEXFqN3EyoSQVHTA', 'DESC');
INSERT INTO Sector VALUES(2, 3, 52374566, 'Sur', 100, 'https://goo.gl/maps/fNEXF34TD43FF4VHTA', 'DISP');
INSERT INTO Sector VALUES(3, 3, 52374566, 'Este', 100, 'https://goo.gl/maps/fNEXFFGHF444yoSQVHTA', 'OCUP');
INSERT INTO Sector(id_pred, id_sect, nom_sect, hect_sect, ub_sect, estado_sect, ci_prod) VALUES(7, 1, 'zona uno', 10, 'Montevideo', 'DISP', 23436644);
INSERT INTO Sector(id_pred, id_sect, nom_sect, hect_sect, ub_sect, estado_sect, ci_prod) VALUES(7, 2, 'zona dos', 10, 'Montevideo', 'DISP', 23436644);
INSERT INTO Sector(id_pred, id_sect, nom_sect, hect_sect, ub_sect, estado_sect, ci_prod) VALUES(7, 3, 'zona tres', 10, 'Montevideo', 'DISP', 23436644);
INSERT INTO Sector VALUES(1, 8, 48390685, 'Este', 5, 'https://goo.gl/maps/JFfsdakD232345', 'DISP');
INSERT INTO Sector VALUES(2, 8, 48390685, 'Sur', 5, 'https://goo.gl/maps/JFfsdakD232345', 'DISP');
INSERT INTO Sector VALUES(3, 8, 48390685, 'Suroeste', 3, 'https://goo.gl/maps/JFfsdakD232345', 'DESC');
INSERT INTO Sector VALUES(4, 8, 48390685, 'Norte', 2, 'https://goo.gl/maps/JFfsdakD232345', 'DISP');
INSERT INTO Sector VALUES(1, 9, 54553267, 'Este', 10, 'https://goo.gl/maps/SAJKFsdnv23556', 'DISP');
INSERT INTO Sector VALUES(2, 9, 54553267, 'Sur', 15, 'https://goo.gl/maps/SAJKFsdnv23556', 'DISP');
INSERT INTO Sector VALUES(3, 9, 54553267, 'Suroeste', 10, 'https://goo.gl/maps/SAJKFsdnv23556', 'DISP');
INSERT INTO Sector VALUES(4, 9, 54553267, 'Norte', 10, 'https://goo.gl/maps/SAJKFsdnv23556', 'DISP');
INSERT INTO Sector VALUES(1, 10, 47548385, 'Este', 5, 'https://goo.gl/maps/AScjsADsdfda2069', 'DISP');
INSERT INTO Sector VALUES(2, 10, 47548385, 'Sur', 5, 'https://goo.gl/maps/AScjsADsdfda2069', 'DISP');
INSERT INTO Sector VALUES(3, 10, 47548385, 'Suroeste', 10, 'https://goo.gl/maps/AScjsADsdfda2069', 'DISP');
INSERT INTO Sector VALUES(4, 10, 47548385, 'Norte', 10, 'https://goo.gl/maps/AScjsADsdfda2069', 'DISP');
INSERT INTO Sector VALUES(1, 11, 56346265, 'Este', 20, 'https://goo.gl/maps/CAsjxDS423566', 'DISP');
INSERT INTO Sector VALUES(2, 11, 56346265, 'Sur', 20, 'https://goo.gl/maps/CAsjxDS423566', 'DISP');
INSERT INTO Sector VALUES(3, 11, 56346265, 'Suroeste', 10, 'https://goo.gl/maps/CAsjxDS423566', 'DISP');
INSERT INTO Sector VALUES(4, 11, 56346265, 'Norte', 10, 'https://goo.gl/maps/CAsjxDS423566', 'DISP');
INSERT INTO Sector VALUES(1, 12, 50706831, 'Oeste', 25, 'https://goo.gl/maps/asd2fr23r2yoSQVHTA', 'DISP');
INSERT INTO Sector VALUES(2, 12, 50706831, 'Sur', 25, 'https://goo.gl/maps/asd2fr23r2yoSQVHTA', 'DISP');

# EVENTOS: (CADA PRODUCTOR PLANTA UN SOLO TIPO DE PLANTACION CER, FRU, O VER) OJO BRUNO TIENE UN ERROR ESTA PARTE PONELE LOS DATOS IGUAL, CUALQUIER COSA COMENTALO
INSERT INTO Evento(id_sect, id_pred, ci_prod, f_ini, f_fin, cat_prod, tipo_prod) VALUES(1,2, 50706831, '2022-10-07', '2023-10-07', 'FRU', 'MANZANA');
INSERT INTO Evento(id_pred, id_sect, ci_prod, f_ini, f_fin, cat_prod, tipo_prod) VALUES(7, 1, 23436644, '2022-10-07', '2023-02-15', 'FRU', 'MANZANA');
INSERT INTO Evento(id_pred, id_sect, ci_prod, f_ini, f_fin, cat_prod, tipo_prod) VALUES(7, 2, 23436644, '2022-10-07', '2023-04-07', 'FRU', 'NARANJA');
INSERT INTO Evento(id_pred, id_sect, ci_prod, f_ini, f_fin, cat_prod, tipo_prod) VALUES(7, 3, 23436644, '2022-10-07', '2023-02-05', 'FRU', 'LIMON');
INSERT INTO Evento(id_sect, id_pred, ci_prod, f_ini, f_fin, cat_prod, tipo_prod) VALUES(1,8, 48390685, '2022-9-07', '2023-9-07', 'VER', 'PAPA ROSADA');
INSERT INTO Evento(id_sect, id_pred, ci_prod, f_ini, f_fin, cat_prod, tipo_prod) VALUES(2,8, 48390685, '2022-8-07', '2023-8-07', 'VER', 'PAPA ROSADA');
INSERT INTO Evento(id_sect, id_pred, ci_prod, f_ini, f_fin, cat_prod, tipo_prod) VALUES(3,8, 48390685, '2022-7-07', '2023-7-07', 'VER', 'ZAPALLO CRI');
INSERT INTO Evento(id_sect, id_pred, ci_prod, f_ini, f_fin, cat_prod, tipo_prod) VALUES(4,8, 48390685, '2022-6-07', '2023-6-07', 'VER', 'ZAPALLO CRI');
INSERT INTO Evento(id_sect, id_pred, ci_prod, f_ini, f_fin, cat_prod, tipo_prod) VALUES(1,9, 54553267, '2022-5-07', '2023-5-07', 'CER', 'TRIGO');
INSERT INTO Evento(id_sect, id_pred, ci_prod, f_ini, f_fin, cat_prod, tipo_prod) VALUES(2,9, 54553267, '2022-4-07', '2023-4-07', 'CER', 'TRIGO');
INSERT INTO Evento(id_sect, id_pred, ci_prod, f_ini, f_fin, cat_prod, tipo_prod) VALUES(3,9, 54553267, '2022-3-07', '2023-3-07', 'CER', 'CEBADA');
INSERT INTO Evento(id_sect, id_pred, ci_prod, f_ini, f_fin, cat_prod, tipo_prod) VALUES(4,9, 54553267, '2022-2-07', '2023-2-07', 'CER', 'CEBADA');

# FERTILIZACION:
INSERT INTO Fertilizacion(id_event, fecha, nivel_crit, equiv_fert) VALUES(1, '2024-10-06', 23.45, 54220.222); 
INSERT INTO Fertilizacion(id_event, fecha, nivel_crit, equiv_fert) VALUES(2, '2023-11-23', 33.23, 54323.332);

# ITEMS, PRODUCTOS E ISUMOS:
INSERT INTO Item(cod_item, peso, nom_item, precio) VALUES(1, 10,'Herbicida Suncho', 300.30);
INSERT INTO Insumo(cod_item, cat_ins, tipo_ins) VALUES(1, 'HERB','OTRO');
INSERT INTO Item(cod_item, peso, nom_item, cant, precio) VALUES(2, 55, 'Manzanas el pocho',  200, 100.10);
INSERT INTO Producto(cod_item, cat_prod, tipo_prod, ci_prod, id_event, f_cosecha) VALUES(2, 'FRU','MANZANA', 50706831, 1, '2022-12-31');
INSERT INTO Item(cod_item, peso, nom_item, precio) VALUES(3, 10000,'Fertilizante Potent', 2000.10);
INSERT INTO Insumo(cod_item, cat_ins, tipo_ins) VALUES(3, 'FERT','OTRO');
INSERT INTO Item(cod_item, peso, nom_item, cant, precio) VALUES(4, 10, 'Naranjas Naranjosas',  1000, 10.20);
INSERT INTO Producto(cod_item, cat_prod, tipo_prod, ci_prod, id_event, f_cosecha) VALUES(4, 'FRU','NARANJA', 23436644, 2, '2023-03-30');
INSERT INTO Item(cod_item, peso, nom_item, precio) VALUES(5, 400,'DTM Deja Todo Muerto ', 500.10);
INSERT INTO Insumo(cod_item, cat_ins, tipo_ins) VALUES(5, 'INSE','OTRO');
INSERT INTO Item(cod_item, peso, nom_item, cant, precio) VALUES(6, 10, 'Papita llenadora',  4000, 20.10);
INSERT INTO Producto(cod_item, cat_prod, tipo_prod, ci_prod, id_event, f_cosecha) VALUES(6, 'VER','PAPA ROSADA', 48390685, 3, '2023-05-23');
INSERT INTO Item(cod_item, peso, nom_item, precio) VALUES(7, 10,'Semillitas Semillot', 10.00);
INSERT INTO Insumo(cod_item, cat_ins, tipo_ins) VALUES(7, 'SEMI','OTRO');
INSERT INTO Item(cod_item, peso, nom_item, cant, precio) VALUES(8, 400, 'Zapallo Caballito',  400, 350.00);
INSERT INTO Producto(cod_item, cat_prod, tipo_prod, ci_prod, id_event, f_cosecha) VALUES(8, 'VER','MANZANA', 48390685, 4, '2023-10-22');
INSERT INTO Item(cod_item, peso, nom_item, precio) VALUES(9, 400,'Chau hongos', 500.00);
INSERT INTO Insumo(cod_item, cat_ins, tipo_ins) VALUES(9, 'FUNG','OTRO');
INSERT INTO Item(cod_item, peso, nom_item, cant, precio) VALUES(10, 1000, 'Trigo Masticable',  30000, 400.00);
INSERT INTO Producto(cod_item, cat_prod, tipo_prod, ci_prod, id_event, f_cosecha) VALUES(10, 'CER','TRIGO', 54553267, 6, '2021-12-30');
INSERT INTO Item(peso, nom_item, precio) VALUES(10,'Herbicida Suncho', 100000.99);
INSERT INTO Insumo(cat_ins, tipo_ins) VALUES('HERB','OTRO');
INSERT INTO Item(peso, nom_item, cant, precio) VALUES(55, 'Manzanas el pocho',  200, 999.9);
INSERT INTO Producto(cat_prod, tipo_prod, ci_prod, id_event, f_cosecha) VALUES('FRU','MANZANA', 50706831, 1, '2022-12-31');

# COMPRA, FACTURA Y EMITE:
INSERT INTO Compra(ci_cliente, cod_item, cant) VALUES(48390685, 2, 10);
INSERT INTO Factura(cod_fact, tipo_fact, costo, total) VALUES(1,'CREDITO',100.00,1000.00);
INSERT INTO Emite(cod_fact, tipo_fact, cod_comp) VALUES(1,'CREDITO',1);

INSERT INTO Compra(ci_cliente, cod_item, cant) VALUES(48390685, 5, 4);
INSERT INTO Factura(cod_fact, tipo_fact, costo, total) VALUES(2,'CREDITO',500.00,1500.00);
INSERT INTO Emite(cod_fact, tipo_fact, cod_comp) VALUES(2,'CREDITO',2);

INSERT INTO Compra(ci_cliente, cod_item, cant) VALUES(48390685, 3, 3);
INSERT INTO Factura(cod_fact, tipo_fact, costo, total) VALUES(3,'CREDITO',2000,6000.00);
INSERT INTO Emite(cod_fact, tipo_fact, cod_comp) VALUES(3,'CREDITO',3);

INSERT INTO Compra(ci_cliente, cod_item, cant) VALUES(50706831, 1, 10);
INSERT INTO Factura(cod_fact, tipo_fact, costo, total) VALUES(4,'CREDITO',999.99,1219.98);
INSERT INTO Emite(cod_fact, tipo_fact, cod_comp) VALUES(4,'CREDITO',1);

###################################
# DATOS DE PRUEBA PARA DESARROLLO #
###################################

# DATOS DE PRUEBA PARA 50706831
# PREDIO 2 Y SECTORES PARA PREDIO 2
# EVENTO Y FERTILIZACION PARA 50706831
# ITEMS PARA 50706831
# COMPRAS PARA 50706831

#SELECT * FROM Evento WHERE ('2023-04-07' BETWEEN f_ini AND f_fin);
#SELECT MAX(id_sect) FROM Sector WHERE id_pred = 1;
#SELECT id_sect, id_pred FROM Sector WHERE id_pred = 2;
#SELECT MAX(id_sect) FROM Sector WHERE id_pred = 1;
#SELECT * FROM Sector;
#select count(*) from Usuario where ci='50706831';
#SELECT MAX(id_pred) FROM Predio; # para imprimir ultima id
#SELECT * FROM Usuario WHERE ci = '50706831';
#SELECT * FROM Productor WHERE ci = '50706831';
#INSERT INTO Telefono VALUES ('50706831','23094563');
#SELECT * FROM Telefono WHERE ci = '50706831';
#DELETE FROM Productor WHERE ci = '50706831';
#SELECT * FROM Productor;
#select * from Administrativo;
#select * from Telefono;
#select * from Predio;
#SELECT Count(*) FROM Usuario WHERE User = 'JuanCarlos' AND pass = '12345';

#Select ci From Usuario Where user = 'jagustin';

#SELECT Usuario.ci, cargo, nom_a, nom_b, ape_a, ape_b, mail, user, pass, calle_a, calle_b, nro_puerta, baja FROM Administrativo INNER JOIN Usuario ON Usuario.ci = '50706831' WHERE Usuario.ci = Administrativo.ci;
#SELECT * FROM Administrativo JOIN Usuario ON Usuario.user = 'Maurito' WHERE Usuario.ci = Administrativo.ci;
#SELECT * FROM Administrativo JOIN Usuario ON Usuario.user = 'JuanCarlos' WHERE Usuario.ci = Administrativo.ci;
#SELECT * FROM Productor JOIN Usuario ON Usuario.user = 'JuanCarlos' WHERE Usuario.ci = Productor.ci;

#SELECT count(*) FROM Administrativo JOIN Usuario ON Usuario.user = 'JuanCarlos' WHERE Usuario.ci = Administrativo.ci;
#SELECT count(*) FROM Productor JOIN Usuario ON Usuario.user = 'JuanCarlos' WHERE Usuario.ci = Productor.ci;

# SHOW VARIABLES WHERE Variable_name = 'hostname' # DEVUELVE HOSTNAME DE SERVIDOR MYSQL
# SHOW VARIABLES WHERE Variable_name = 'port' # DEVUELVE PUERTO DE SERVIDOR MYSQLid_pred

# UPDATE 50706831
UPDATE Administrativo SET cargo = 'Jefe' WHERE ci = '50706831';
UPDATE Productor SET rut_prod = '123456789112', produce = 'VER' WHERE ci = '50706831';
UPDATE Usuario SET nom_a = 'MAURO', ape_a = 'RODRIGUEZ', ape_b = 'ROCHA', mail = 'marutioh@mail.com', user = 'Maurito', pass = 'gdyb21LQTcIANtvYMT7QVQ==', calle_a = 'Bv. Artigas', calle_b = 'Requena', nro_puerta = '1234', baja = False WHERE ci = '50706831'; # contraseña 1234
UPDATE Usuario SET calle_a = 'Bv. Artigas', calle_b = 'Requena' WHERE ci = '50706831';
UPDATE Usuario SET pass = 'gnzLDuqKcGxMNKFokfhOew==' WHERE user = 'JuanCarlos'; # contraseña 12345

#UPDATES DE PRUEBA
UPDATE Predio SET nom_pred = 'Pajonal', hect_pred = 10, ub_pred = 'https://goo.gl/maps/J44rrr22DHD2932' WHERE id_pred = 5;
UPDATE Predio SET nom_pred = 'La Chacrita', hect_pred = 750 WHERE id_pred = 2;
UPDATE Sector SET ci_prod = '52374566', nom_sect = 'Este', hect_sect = 100, ub_sect = 'https://goo.gl/maps/fNEXFFGHF444yoSQVHTA', estado_sect = 'DISP' WHERE id_pred = 3 AND id_sect = 3;
#UPDATE Sector SET ci_prod = '50706831', nom_sect = 'Norte', hect_sect = 150, ub_sect = 'https://goo.gl/maps/fNEXFqN3EyoSQVHTA', estado_sect = 'DESC' WHERE id_sect = 1 AND id_pred = 2;

