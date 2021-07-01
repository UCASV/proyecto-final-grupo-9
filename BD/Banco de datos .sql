-- Proyecto de BD
--Grupo #9
-- Integrantes:  
-- 00115220 Josue Gabriel Argueta López
-- 00117220 Julio José Escamilla Pérez
-- 00136020 Brian Darwin Carranza Campos
-- 00084320 Guillermo Josué Galdámez Rivera

CREATE DATABASE Vaccination_Management;
USE Vaccination_Management;
SET LANGUAGE us_english;

CREATE TABLE CITIZEN(
	dui INT PRIMARY KEY,
	name VARCHAR(50),
	direction VARCHAR(30),
	phone VARCHAR(9),
	mail VARCHAR(30)
);

CREATE TABLE MANAGER(
	id INT PRIMARY KEY,
	password VARCHAR(30),
	institutional_mail VARCHAR(30),
	home_direction VARCHAR(30),
	employee_type VARCHAR(30),
	name VARCHAR(50)
);

CREATE TABLE CABIN(
	id INT PRIMARY KEY,
	direction VARCHAR(30),
	phone VARCHAR(9),
	position VARCHAR(30),
	mail VARCHAR(30)
);

CREATE TABLE APPOINTMENT_1(
	id INT PRIMARY KEY IDENTITY,
	date_time DATETIME,
	place VARCHAR(30),
	dui_citizen INT NOT NULL
	CONSTRAINT FK_CITIZENXAPPOINTMET_1 FOREIGN KEY(dui_citizen) REFERENCES CITIZEN (dui)
);

CREATE TABLE APPOINTMENT_2(
	id INT PRIMARY KEY IDENTITY,
	date_time DATETIME,
	place VARCHAR(30),
	dui_citizen INT NOT NULL
	CONSTRAINT FK_CITIZENXAPPOINTMET_2 FOREIGN KEY(dui_citizen) REFERENCES CITIZEN (dui)
);

CREATE TABLE SIDE_EFFECT(
	id INT PRIMARY KEY IDENTITY,
	name VARCHAR(50)
);

CREATE TABLE DOSE_1(
	id INT PRIMARY KEY IDENTITY,
	date_time DATETIME,
	dui_citizen INT NOT NULL
	CONSTRAINT FK_CITIZENXDOSE_1 FOREIGN KEY(dui_citizen) REFERENCES CITIZEN (dui)
);

CREATE TABLE DOSE_2(
	id INT PRIMARY KEY IDENTITY,
	date_time DATETIME,
	dui_citizen INT NOT NULL
	CONSTRAINT FK_CITIZENXDOSE_2 FOREIGN KEY(dui_citizen) REFERENCES CITIZEN (dui)
);

CREATE TABLE REGISTRATION_START(
	id_manager INT FOREIGN KEY REFERENCES MANAGER(id) NOT NULL,
	id_cabin INT FOREIGN KEY REFERENCES CABIN(id) NOT NULL,
	date_time DATETIME
	CONSTRAINT PK_MANAGERXCABIN PRIMARY KEY(id_manager,id_cabin)
);

CREATE TABLE CABINXAPPOINTMENT_1(
	id_cabin INT FOREIGN KEY REFERENCES CABIN(id) NOT NULL,
	id_appointment_1 INT FOREIGN KEY REFERENCES APPOINTMENT_1(id) NOT NULL,
	CONSTRAINT PK_CABINXAPPOINTMET_1 PRIMARY KEY(id_cabin,id_appointment_1)
);

CREATE TABLE CABINXAPPOINTMENT_2(
	id_cabin INT FOREIGN KEY REFERENCES CABIN(id) NOT NULL,
	id_appointment_2 INT FOREIGN KEY REFERENCES APPOINTMENT_2(id) NOT NULL,
	CONSTRAINT PK_CABINXAPPOINTMET_2 PRIMARY KEY(id_cabin,id_appointment_2)
);

CREATE TABLE CHRONIC_DISEASE(
	id INT PRIMARY KEY IDENTITY,
	name VARCHAR(50),
	dui_citizen INT NOT NULL
	CONSTRAINT FK_CITIZENXCHRONIC_DISEASE FOREIGN KEY(dui_citizen) REFERENCES CITIZEN (dui)
);

CREATE TABLE INSTITUTION(
	id INT PRIMARY KEY,
	name VARCHAR(50),
	dui_citizen INT NOT NULL
	CONSTRAINT FK_CITIZENXINSTITUTION FOREIGN KEY(dui_citizen) REFERENCES CITIZEN (dui)
);

CREATE TABLE PRIORITY_GROUP(
	id INT PRIMARY KEY IDENTITY,
	name VARCHAR(50),
	dui_citizen INT NOT NULL
	CONSTRAINT FK_CITIZENXPRIORITY_GROUP FOREIGN KEY(dui_citizen) REFERENCES CITIZEN (dui)
);

CREATE TABLE WAIT_ROW1(
	id INT PRIMARY KEY IDENTITY,
	date_time DATETIME,
	dui_appointment_1 INT NOT NULL
	CONSTRAINT FK_APPOINTMENT_1XWAIT_ROW1 FOREIGN KEY(dui_appointment_1) REFERENCES APPOINTMENT_1 (id)
);

CREATE TABLE WAIT_ROW2(
	id INT PRIMARY KEY IDENTITY,
	date_time DATETIME,
	dui_appointment_2 INT NOT NULL
	CONSTRAINT FK_APPOINTMENT_2XWAIT_ROW2 FOREIGN KEY(dui_appointment_2) REFERENCES APPOINTMENT_2 (id)
);

CREATE TABLE DOSE_1XSIDE_EFFECT(
	id_side_effect INT FOREIGN KEY REFERENCES SIDE_EFFECT(id) NOT NULL,
	id_dose_1 INT FOREIGN KEY REFERENCES DOSE_1(id) NOT NULL,
	time VARCHAR(2)
	CONSTRAINT PK_DOSE_1XSIDE_EFFECT PRIMARY KEY(id_side_effect,id_dose_1)
);

CREATE TABLE DOSE_2XSIDE_EFFECT(
	id_side_effect INT FOREIGN KEY REFERENCES SIDE_EFFECT(id) NOT NULL,
	id_dose_2 INT FOREIGN KEY REFERENCES DOSE_2(id) NOT NULL,
	time VARCHAR(2)
	CONSTRAINT PK_DOSE_2XSIDE_EFFECT PRIMARY KEY(id_side_effect,id_dose_2)
);

INSERT INTO CITIZEN VALUES(962912784, 'Alberto Vásquez', 'Urbanizacion Y Pasaje Palomo 4, Número 10, Colonia Layco. , San Miguelito', '7561-1038','A_Vasquez@gmail.com' );
INSERT INTO CITIZEN VALUES(238832784, 'Camila ALvarenga','1 Er. Calle Poniente #2016 1 Cuadra Arriba De Liceo Salvadoreño, Colonia Flor B', '2202-6105','Cami_2345z@gmail.com');
INSERT INTO CITIZEN VALUES(823671729, 'Alexandra Castillo', 'Carretera Troncal Del Norte Terreno, Edif. Zo', '2202-6106','A_lomax@gmail.com');
INSERT INTO CITIZEN VALUES(123345211, 'Alejandro Rivas', 'Colonia Flor Blanca', '2202-6118','A_Destroyer55@gmail.com');
INSERT INTO CITIZEN VALUES(453628019, 'Juan Torres', 'Colonia Militar, San Jacinto', ' 2202-6117','NoobMaster68@gmail.com');
INSERT INTO CITIZEN VALUES(729000123, 'Benito Alas', 'Lourdes Cólon', ' 2202-6122','Benito_aLas@gmail.com');
INSERT INTO CITIZEN VALUES(134312312, 'Carlos Reyes', 'San Salvador', '7784-2121','cARLOS@gmail.com');
INSERT INTO CITIZEN VALUES(345356474, 'Xiamora López', 'Calle La Mascota 923b, San Salvador, El Salvador', '9124-4567','X14M0R4@gmail.com');
INSERT INTO CITIZEN VALUES(234456556, 'Elsa Quito', ' Colonia Buenos Aires 3, Diagonal Centroamérica, Avenida Alvarado', '2396-4506','Elsa_Dysney@gmail.com');
INSERT INTO CITIZEN VALUES(612789268, 'Johana Hércules', ' 1ª Calle Poniente entre 60ª Avenida Norte y Boulevard Constitución No. 3549', '1234-5678','Valjyria_45@gmail.com');

INSERT INTO MANAGER VALUES(10002, 'contraseña', 'CarlosVega@MinisterioDeSalud.edu.sv', 'Cumbres de Cuscatlán', 'Medico', 'Carlos Vega');
INSERT INTO MANAGER VALUES(97238, 'sunshine', 'BarryAllen@MinisterioDeSalud.edu.sv', 'Santa Elena', 'Enfermero', 'Barry Allen');
INSERT INTO MANAGER VALUES(12344, 'admin', 'BruceWayne@MinisterioDeSalud.edu.sv', 'Colonia Maquilishuat', 'Medico', 'Bruce Wayne');
INSERT INTO MANAGER VALUES(43653, 'welcome', 'BruceBanner@MinisterioDeSalud.edu.sv', 'Colonia San Benito', 'Medico', 'Bruce Banner');
INSERT INTO MANAGER VALUES(35632, 'monkey', 'OliverQueen@MinisterioDeSalud.edu.sv', 'Colonia Escalón', 'Medico', 'Oliver Queen');
INSERT INTO MANAGER VALUES(13334, 'donald', 'DianaPrince@MinisterioDeSalud.edu.sv', 'Residencial Palmira', 'Enfermera', 'Diana Prince');
INSERT INTO MANAGER VALUES(34566, 'qwerty123', 'SteveCarrillo@MinisterioDeSalud.edu.sv', 'Residencial las Piletas', 'Medico', 'Steve Carrillo');
INSERT INTO MANAGER VALUES(45322, 'charlie', 'GlendaTorres@MinisterioDeSalud.edu.sv', 'Nuevo Cuscatlán', 'Enfermera', 'Glenda Torres');
INSERT INTO MANAGER VALUES(14353, 'abc123', 'MaríaSerrano@MinisterioDeSalud.edu.sv', 'La Montaña', 'Enfermera', 'María Luisa Serrano');
INSERT INTO MANAGER VALUES(67778, 'ncelite', 'OliviaGaldámez@MinisterioDeSalud.edu.sv', 'Lomas de San Francisco', 'Enfermera', 'Olivia Galdámez');
