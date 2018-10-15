# Project Title

Este proyecto se desarrollo para demostrar las habilidades de desarrollo con las que contaba en este momento, el proyecto fue desarrollado en C# Utilizando Web Aplication MVC 5 y usando como base de datos SQL server 2012.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

Para correr este sistema solo se necesita tener previamente una base de datos con las siguientes caracteristicas:

* DATA BASE: Examen
* ADDRESS: DESKTOP-H4HGR3I
* USER: user
* PASSWORD: user123

Y tener tablas con la siguiente estructura:

CREATE TABLE Department  
(
	IdDepartment INT NOT NULL IDENTITY(1,1),
	Name VARCHAR(100) NOT NULL,
	PRIMARY KEY (IdDepartment)
);

CREATE TABLE Employ (
    IdEmploy INT NOT NULL IDENTITY(1,1),
    Name VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	PhoneNumber VARCHAR(15) NOT NULL,
	Email VARCHAR(320) NOT NULL,
    IdDepartment INT NOT NULL,
    PRIMARY KEY (IdEmploy),
    CONSTRAINT FK_EmployDepartment FOREIGN KEY (IdDepartment)
    REFERENCES Department(IdDepartment)
);

# Script para registros

Adicionalmente se puede generar un script para llenar con 100 registros de empleados el sistema

# Script

insert into Department(Name) values
('Recursos Humanos'),
('Publicidad'),
('Auxiliar Administrativo'),
('Finanzas'),
('Publicidad y Mercadotecnia'),
('Informática')

insert into Employ (Name,LastName,PhoneNumber,Email,IdDepartment) values
('Jose','Banda','3128984756','Empleado@gmail.com',6),
('Alberto','Boj','3128984756','Empleado@gmail.com',1),
('Amparo','Ramos','3128984756','Empleado@gmail.com',1),
('Amparo','Hernandez','3128984756','Empleado@gmail.com',1),
('Ana','Almira','3128984756','Empleado@gmail.com',1),
('Angel','Aldeguer','3128984756','Empleado@gmail.com',1),
('Angel','Andreu','3128984756','Empleado@gmail.com',1),
('Angel','Garcia','3128984756','Empleado@gmail.com',1),
('Antonia','Maria','3128984756','Empleado@gmail.com',1),
('Antonio','Box','3128984756','Empleado@gmail.com',1),
('Antonio','Espuch','3128984756','Empleado@gmail.com',1),
('Antonio','Parada','3128984756','Empleado@gmail.com',1),
('Antonio','Vidal','3128984756','Empleado@gmail.com',1),
('Armin','Osterreich','3128984756','Empleado@gmail.com',1),
('Asun','Martinez','3128984756','Empleado@gmail.com',1),
('Asun','Fructuoso','3128984756','Empleado@gmail.com',1),
('Berta','Walther','3128984756','Empleado@gmail.com',1),
('Carmen','Dols','3128984756','Empleado@gmail.com',1),
('Cecilia','Walther','3128984756','Empleado@gmail.com',1),
('Clara','Imbernon','3128984756','Empleado@gmail.com',2),
('Conchita','Walther','3128984756','Empleado@gmail.com',2),
('Cristian','Fructuoso','3128984756','Empleado@gmail.com',2),
('Cristina','Sanchez','3128984756','Empleado@gmail.com',2),
('Cristina','Martine','3128984756','Empleado@gmail.com',2),
('Eduardo','Albaladejo','3128984756','Empleado@gmail.com',2),
('Javier','Torregrosa','3128984756','Empleado@gmail.com',2),
('Emilio','Albaladejo','3128984756','Empleado@gmail.com',2),
('Emilio','Argueso','3128984756','Empleado@gmail.com',2),
('Enrique','Auñon','3128984756','Empleado@gmail.com',2),
('Encarna','Garres','3128984756','Empleado@gmail.com',2),
('Encarnita','Fructuoso','3128984756','Empleado@gmail.com',2),
('Esther','Andreu','3128984756','Empleado@gmail.com',2),
('Esther','Diaz','3128984756','Empleado@gmail.com',2),
('Esther','Fernandez','3128984756','Empleado@gmail.com',2),
('Felipe','Fructuoso','3128984756','Empleado@gmail.com',2),
('Fernanda','Fructuoso','3128984756','Empleado@gmail.com',2),
('Fernando','Albaladejo','3128984756','Empleado@gmail.com',2),
('Fernando','Garcia','3128984756','Empleado@gmail.com',2),
('Finin','Gutierrez','3128984756','Empleado@gmail.com',3),
('Fulgencio','Almira','3128984756','Empleado@gmail.com',3),
('Gerardo','Albaladejo','3128984756','Empleado@gmail.com',3),
('Gracia','Martinez','3128984756','Empleado@gmail.com',3),
('Guzman','Ballesta','3128984756','Empleado@gmail.com',3),
('Helena','Griñan','3128984756','Empleado@gmail.com',3),
('Irene','Tejuelo','3128984756','Empleado@gmail.com',3),
('Iris','Jung','3128984756','Empleado@gmail.com',3),
('Isabel','Martinez','3128984756','Empleado@gmail.com',3),
('Ivan','Martinez','3128984756','Empleado@gmail.com',3),
('Jaime','Garcia','3128984756','Empleado@gmail.com',3),
('Jaqueline','Guillamon','3128984756','Empleado@gmail.com',3),
('Jens','Blaum','3128984756','Empleado@gmail.com',3),
('Joan','Blaum','3128984756','Empleado@gmail.com',3),
('Joaquin','Saez','3128984756','Empleado@gmail.com',3),
('Joaquin','Perez','3128984756','Empleado@gmail.com',3),
('Jose','Gonzalez','3128984756','Empleado@gmail.com',3),
('Jose','Miñano','3128984756','Empleado@gmail.com',3),
('Jose','Minguez','3128984756','Empleado@gmail.com',4),
('Jose','Barredo','3128984756','Empleado@gmail.com',4),
('Jose','Juan','3128984756','Empleado@gmail.com',4),
('Jose','Penades','3128984756','Empleado@gmail.com',4),
('Jose','Macia','3128984756','Empleado@gmail.com',4),
('Jose','Aniorte','3128984756','Empleado@gmail.com',4),
('Jose','Ruiz','3128984756','Empleado@gmail.com',4),
('Jose','Canales','3128984756','Empleado@gmail.com',4),
('Josefina','Canales','3128984756','Empleado@gmail.com',4),
('Juan','Bellot','3128984756','Empleado@gmail.com',4),
('Juan','Torregrosa','3128984756','Empleado@gmail.com',4),
('Juan','Ferrandez','3128984756','Empleado@gmail.com',4),
('Juan','Torregrosa','3128984756','Empleado@gmail.com',4),
('Julio','Garcia','3128984756','Empleado@gmail.com',4),
('Kevin','Banda','3128984756','Empleado@gmail.com',4),
('Leocadia','Perez','3128984756','Empleado@gmail.com',4),
('Maria','Pizana','3128984756','Empleado@gmail.com',4),
('Maria','Martinez','3128984756','Empleado@gmail.com',4),
('Maria','Carrasco','3128984756','Empleado@gmail.com',4),
('Maria','Galvez','3128984756','Empleado@gmail.com',4),
('Maria','Dolores','3128984756','Empleado@gmail.com',4),
('Maria','Coral','3128984756','Empleado@gmail.com',4),
('Isabel','Ribera','3128984756','Empleado@gmail.com',5),
('Maria','Quiles','3128984756','Empleado@gmail.com',5),
('Maria','Cayuelas','3128984756','Empleado@gmail.com',5),
('Maria','Quesada','3128984756','Empleado@gmail.com',5),
('Maria','Zambrana','3128984756','Empleado@gmail.com',5),
('Maria','Navarro','3128984756','Empleado@gmail.com',5),
('Maite','Garcia','3128984756','Empleado@gmail.com',5),
('Manuela','Ferrandez','3128984756','Empleado@gmail.com',5),
('Manolo','Carbonel','3128984756','Empleado@gmail.com',6),
('Manuel','Vera','3128984756','Empleado@gmail.com',6),
('Manuel','Mazon','3128984756','Empleado@gmail.com',6),
('Marco','Mateo','3128984756','Empleado@gmail.com',6),
('Mari','Lozano','3128984756','Empleado@gmail.com',6),
('Mari','Palomo','3128984756','Empleado@gmail.com',6),
('Mari','Bautista','3128984756','Empleado@gmail.com',6),
('Mari','Torres','3128984756','Empleado@gmail.com',6),
('Maria','Fructuoso','3128984756','Empleado@gmail.com',6),
('Maria','Puigcerver','3128984756','Empleado@gmail.com',6),
('Mari','Matera','3128984756','Empleado@gmail.com',6),
('Maria','Ros','3128984756','Empleado@gmail.com',6),
('Marian','Garcia','3128984756','Empleado@gmail.com',6),
('Maribel','Matera','3128984756','Empleado@gmail.com',6)
