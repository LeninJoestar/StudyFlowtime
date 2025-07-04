---Creamos la base de datos para el proyecto
--CREATE DATABASE FlowTime

use FlowTime

---Creamos las tablas necesarias y correspondientes para almacenar los datos
CREATE TABLE Usuarios(
	Usuario_id INT IDENTITY(1,1) PRIMARY KEY,
	NombreCompleto VARCHAR(100) NOT NULL,
	NombreUsuario VARCHAR(15) NOT NULL,
	Contrasena VARCHAR(10) NOT NULL
)

CREATE TABLE Cronometro(
	Fecha DATE NOT NULL,
	TiempoEstudioMinutos VARCHAR(10) NOT NULL,
	TiempoDescansoMinutos VARCHAR(10) NOT NULL,
)

CREATE TABLE RegistroSesiones (
    RegistroSesion_id INT IDENTITY(1,1) PRIMARY KEY,
    Usuario_id INT NOT NULL,
    FechaInicio DATETIME NOT NULL,
    FechaFin DATETIME,
    DuracionMinutos AS DATEDIFF(MINUTE, FechaInicio, ISNULL(FechaFin, GETDATE()))
)

CREATE TABLE TiempoPomodoro(
	Fecha DATE NOT NULL,
	TiempoEstudioMinutos INT NOT NULL,
	TiempoDescansoMinutos INT NOT NULL,
	Usuario_id INT NOT NULL
    FOREIGN KEY (Usuario_id) REFERENCES Usuarios(Usuario_id)
)

CREATE TABLE TiempoFlowtime(
	Fecha DATE NOT NULL,
	TiempoEstudioMinutos INT NOT NULL,
	TiempoDescansoMinutos INT NOT NULL,
	Usuario_id INT NOT NULL
    FOREIGN KEY (Usuario_id) REFERENCES Usuarios(Usuario_id)
)

CREATE TABLE EstadosDeAnimo (
    Usuario_id INT NOT NULL,
    Estados VARCHAR(255) NOT NULL,
    Fecha DATE NOT NULL,
    FOREIGN KEY (Usuario_id) REFERENCES Usuarios(Usuario_id)
)

CREATE TABLE Notario (
    Usuario_id INT NOT NULL,
	notas VARCHAR(70) NOT NULL
	FOREIGN KEY (Usuario_id) REFERENCES Usuarios(Usuario_id)
)

--INSERT INTO Usuarios (NombreCompleto, NombreUsuario, Contrasena)
--VALUES ('Lenin Arriaga', 'Lenin556', 'Lenin789'),
--       ('Eduardo Gonzalez', 'eduardo556', 'eduardo789')

--CREATE TRIGGER trg_TiempoDescansoMinutos_Check
--ON TiempoPomodoro
--INSTEAD OF INSERT
--AS
--BEGIN
--    INSERT INTO TiempoPomodoro (Fecha, TiempoEstudioMinutos, TiempoDescansoMinutos, Usuario_id)
--    SELECT 
--        Fecha,
--        TiempoEstudioMinutos,
--        CASE WHEN TiempoDescansoMinutos < 0 THEN 0 ELSE TiempoDescansoMinutos END,
--        Usuario_id
--    FROM inserted
--END

--DELETE FROM TiempoPomodoro
