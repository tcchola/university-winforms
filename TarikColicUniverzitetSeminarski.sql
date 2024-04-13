CREATE DATABASE Univerzitet
USE Univerzitet

------------------TABLE------------------

CREATE TABLE Drzave(
	drzavaID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	nazivDrzave NVARCHAR(50) NOT NULL,
);

CREATE TABLE Gradovi(
	gradID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	nazivGrada NVARCHAR(50) NOT NULL,
	drzavaID INT FOREIGN KEY REFERENCES Drzave(drzavaID) NOT NULL
);

CREATE TABLE Korisnici(
	korisnikID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ime NVARCHAR(50) NOT NULL,
	prezime NVARCHAR(50) NOT NULL,
	datumRodjenja DATETIME NOT NULL,
	email NVARCHAR(100) NOT NULL,
	username NVARCHAR(50) NOT NULL,
	pssw NVARCHAR(100) NOT NULL,
	isProfesor BIT, --ako je 1 prof, ako je 0 ucenik
	gradID INT FOREIGN KEY REFERENCES Gradovi(gradID) NOT NULL
);

CREATE TABLE Profesori(
	profesorID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	imeProfesora NVARCHAR(50) NOT NULL,
	prezimeProfesora NVARCHAR(50) NOT NULL,
	datumRodjenjaProfesora DATETIME NOT NULL,
	gradID INT FOREIGN KEY REFERENCES Gradovi(gradID) NOT NULL,
	emailProfesora NVARCHAR(100),
	zvanjeProfesora NVARCHAR(50)
);

CREATE TABLE Studenti(
	studentID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	imeStudenta NVARCHAR(50) NOT NULL,
	prezimeStudenta NVARCHAR(50) NOT NULL,
	datumRodjenjaStudenta DATETIME NOT NULL,
	gradID INT FOREIGN KEY REFERENCES Gradovi(gradID) NOT NULL,
	emailStudenta NVARCHAR(100),
	indexStudenta NVARCHAR(10) NOT NULL
);
-- econ, poduzetnistvo, mat, bos, eng, sah, tech.pismenost, 
CREATE TABLE Predmeti(
	predmetID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	nazivPredmeta NVARCHAR(50) NOT NULL,
	sifraPredmeta NVARCHAR(10) NOT NULL,
);

CREATE TABLE Ocjene(
	ocjenaID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ocjena INT NOT NULL,
	datumOcjene DATETIME NOT NULL,
	profesorID INT FOREIGN KEY REFERENCES Profesori(profesorID) NOT NULL,
	studentID INT FOREIGN KEY REFERENCES Studenti(studentID) NOT NULL,
	predmetID INT FOREIGN KEY REFERENCES Predmeti(predmetID) NOT NULL
);

CREATE TABLE ProfesoriPredmeti(
	profesorPredmetID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	profesorID INT FOREIGN KEY REFERENCES Profesori(profesorID) NOT NULL,
	predmetID INT FOREIGN KEY REFERENCES Predmeti(predmetID) NOT NULL
);

------------------PROCEDURE------------------

CREATE PROCEDURE Register
@ime NVARCHAR(50),    @prezime NVARCHAR(50),  @datumRodjenja DATETIME,
@email NVARCHAR(100), @username NVARCHAR(50), @pssw NVARCHAR(100),
@isProf BIT,          @gradID INT
AS BEGIN
	INSERT INTO Korisnici 
	VALUES(@ime, @prezime, @datumRodjenja, @email, @username, @pssw, @isProf, @gradID)
END

CREATE PROCEDURE RegisterStudent
@ime NVARCHAR(50), @prezime NVARCHAR(50),  @datumRodjenja DATETIME,
@gradID INT,	   @email NVARCHAR(100),   @index NVARCHAR(10)
AS BEGIN
	INSERT INTO Studenti VALUES(@ime, @prezime, @datumRodjenja, @gradID, @email, @index)
END

CREATE PROCEDURE RegisterProfesori
@ime NVARCHAR(50), @prezime NVARCHAR(50),  @datumRodjenja DATETIME,
@gradID INT,	   @email NVARCHAR(100),   @zvanje NVARCHAR(10)
AS BEGIN
	INSERT INTO Profesori VALUES(@ime, @prezime, @datumRodjenja, @gradID, @email, @zvanje)
END

--ovdje select nesto (user) pa na C# ako nije null idi dalje
CREATE PROCEDURE Login
@username NVARCHAR(50), @pssw NVARCHAR(100)
AS BEGIN
	SELECT * FROM Korisnici
	where username LIKE @username AND pssw LIKE @pssw
END

--prikaz gradova za combobox
CREATE PROCEDURE prikaz_gradova_cmbx
AS BEGIN
	SELECT g.gradID, g.nazivGrada+', '+d.nazivDrzave as 'gradDrzava'
	FROM Gradovi as g
	JOIN Drzave as d on g.drzavaID=d.drzavaID
	ORDER BY gradDrzava
END

------------------PROCEDURE ZA STUDENTE------------------

CREATE PROCEDURE prikazi_spisak_predmeta_studenta
AS BEGIN
	SELECT * FROM Predmeti
END

--prikaz ocjena za predmete ucenika po IDu i prosjecnu ocjenu.
--Ucenik je odredjen uslovom korisnik->isProfesor=false.
--UcenikID je odabran preko comboboxa.
CREATE PROCEDURE prikaz_ocjena_predmeta_ucenika_po_korisnikID
@studentID INT
AS BEGIN
	SELECT p.nazivPredmeta, o.ocjena, o.datumOcjene, AVG(o.ocjena) as 'prosjek'
	FROM Ocjene as o
	JOIN Profesori as prof on o.profesorID=prof.profesorID
	JOIN Studenti as s on o.studentID=s.studentID
	JOIN Predmeti as p on o.predmetID=p.predmetID
	WHERE s.studentID=@studentID
	GROUP BY nazivPredmeta, ocjena, datumOcjene
	ORDER BY o.datumOcjene ASC
END

------------------PROCEDURE ZA PROFESORE------------------

--prikazi podatke o svim profesorima
CREATE PROCEDURE prikazi_podatke_profesora
AS BEGIN
	SELECT prof.imeProfesora+' '+prof.prezimeProfesora as 'imePrezime', prof.zvanjeProfesora,
		   prof.datumRodjenjaProfesora, prof.emailProfesora, g.nazivGrada as 'gradRodjenja'
	FROM Profesori as prof
	JOIN Gradovi as g on prof.gradID=g.gradID
END

--prikazi podatke za sve ucenike
