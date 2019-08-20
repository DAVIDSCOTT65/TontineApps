CREATE TABLE Historique_Inscription
(
	Id int primary key identity (1,1),
	Numero int,
	Nom VARCHAR(50),
	Postnom VARCHAR(50),
	Prenom VARCHAR(50),
	Sexe VARCHAR,
	Designation_Round VARCHAR(100),
	Date_Inscription Date,
	UserSession VARCHAR(30),
	Date_Mis_à_jour dateTime,
	ActionUser VARCHAR(100)
)
GO
CREATE TRIGGER InsertHistoriqueInscription ON Inscription for INSERT 
AS 
BEGIN
	declare @id int;
	declare @refmembre int;
	declare @refround int;
	declare @dateinscrit date;
	declare @usersession varchar(50)

	SELECT @id = Id from inserted
	SELECT @refmembre = Ref_Membre from inserted
	SELECT @refround = Ref_Round from inserted
	SELECT @dateinscrit = Date_Inscription from inserted
	SELECT @usersession = UserSession from inserted

	DECLARE @nom VARCHAR(100);
	SELECT @nom = Nom From Membre WHERE Id=@refmembre
	DECLARE @postnom VARCHAR(100)
	SELECT @postnom = Postnom FROM Membre Where Id=@refmembre
	DECLARE @prenom VARCHAR(100);
	SELECT @prenom = Prenom From Membre WHERE Id=@refmembre
	DECLARE @sex VARCHAR;
	SELECT @sex = Sexe From Membre WHERE Id=@refmembre
	DECLARE @round VARCHAR(100);
	SELECT @round = Designation From TRound WHERE Id=@refround

	INSERT INTO Historique_Inscription VALUES (@id,@nom,@postnom,@prenom,@sex,@round,@dateinscrit,@usersession,GETDATE(),'Insertion')
END
GO
CREATE TRIGGER InsertHistoriqueUpdateInscription ON Inscription for UPDATE 
AS 
BEGIN
	declare @id int;
	declare @refmembre int;
	declare @refround int;
	declare @dateinscrit date;
	declare @usersession varchar(50)

	SELECT @id = Id from inserted
	SELECT @refmembre = Ref_Membre from inserted
	SELECT @refround = Ref_Round from inserted
	SELECT @dateinscrit = Date_Inscription from inserted
	SELECT @usersession = UserSession from inserted

	DECLARE @nom VARCHAR(100);
	SELECT @nom = Nom From Membre WHERE Id=@refmembre
	DECLARE @postnom VARCHAR(100)
	SELECT @postnom = Postnom FROM Membre Where Id=@refmembre
	DECLARE @prenom VARCHAR(100);
	SELECT @prenom = Prenom From Membre WHERE Id=@refmembre
	DECLARE @sex VARCHAR;
	SELECT @sex = Sexe From Membre WHERE Id=@refmembre
	DECLARE @round VARCHAR(100);
	SELECT @round = Designation From TRound WHERE Id=@refround

	INSERT INTO Historique_Inscription VALUES (@id,@nom,@postnom,@prenom,@sex,@round,@dateinscrit,@usersession,GETDATE(),'Modification')
END
GO
CREATE TRIGGER InsertHistoriqueDeleteInscription ON Inscription for DELETE 
AS 
BEGIN
	declare @id int;
	declare @refmembre int;
	declare @refround int;
	declare @dateinscrit date;
	declare @usersession varchar(50)

	SELECT @id = Id from deleted
	SELECT @refmembre = Ref_Membre from deleted
	SELECT @refround = Ref_Round from deleted
	SELECT @dateinscrit = Date_Inscription from deleted
	SELECT @usersession = UserSession from deleted

	DECLARE @nom VARCHAR(100);
	SELECT @nom = Nom From Membre WHERE Id=@refmembre
	DECLARE @postnom VARCHAR(100)
	SELECT @postnom = Postnom FROM Membre Where Id=@refmembre
	DECLARE @prenom VARCHAR(100);
	SELECT @prenom = Prenom From Membre WHERE Id=@refmembre
	DECLARE @sex VARCHAR;
	SELECT @sex = Sexe From Membre WHERE Id=@refmembre
	DECLARE @round VARCHAR(100);
	SELECT @round = Designation From TRound WHERE Id=@refround

	INSERT INTO Historique_Inscription VALUES (@id,@nom,@postnom,@prenom,@sex,@round,@dateinscrit,@usersession,GETDATE(),'Suppression')
END
---------------------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE Historique_Cotisation
(
	Id int identity(1,1),
	CodeCotisation int,
	Matricule VARCHAR(20),
	Nom VARCHAR(100),
	Postnom VARCHAR(100),
	Prenom VARCHAR(100),
	Sexe VARCHAR,
	NumeroSemaine int,
	Date_Cotisation datetime,
	Date_Concernee date,
	DesignationFrais VARCHAR(50),
	Montant float,
	UserSession VARCHAR(30),
	Date_Operation DATETIME,
	ActionUser VARCHAR(20)
)
GO
CREATE TRIGGER InsertHistoriqueInsertionCotisation ON Cotisation for INSERT 
AS
BEGIN
	DECLARE @code int;
	DECLARE @ref_inscrit int;
	DECLARE @ref_semaine int;
	DECLARE @datecotise datetime;
	DECLARE @dateconcern Date;
	DECLARE @ref_frais int;
	DECLARE @montant float;
	DECLARE @usersession VARCHAR(30)

	SELECT @code = Id from inserted
	SELECT @datecotise = Date_Cotisation from inserted
	SELECT @dateconcern = Date_Concernee from inserted
	SELECT @montant = Montant from inserted
	SELECT @usersession = UserSession from inserted

	DECLARE @matricule VARCHAR(30);
	SELECT @matricule = Matricule from Membre WHERE Id=(SELECT Ref_Membre From Inscription WHERE Id=@ref_inscrit)
	DECLARE @nom VARCHAR(50);
	SELECT @nom = Nom from Membre WHERE Id=(SELECT Ref_Membre From Inscription WHERE Id=@ref_inscrit)
	DECLARE @postnom VARCHAR(50);
	SELECT @postnom = Postnom from Membre WHERE Id=(SELECT Ref_Membre From Inscription WHERE Id=@ref_inscrit)
	DECLARE @prenom VARCHAR(50);
	SELECT @prenom = Postnom from Membre WHERE Id=(SELECT Ref_Membre From Inscription WHERE Id=@ref_inscrit)
	DECLARE @sexe VARCHAR;
	SELECT @sexe = Sexe from Membre WHERE Id=(SELECT Ref_Membre From Inscription WHERE Id=@ref_inscrit)
	DECLARE @numerosemaine int;
	SELECT @numerosemaine = Numero From Semaine Where Id=@ref_semaine
	DECLARE @designation VARCHAR(50);
	SELECT @designation = Designation from Type_Frais WHERE Id=@ref_frais

	INSERT INTO Historique_Cotisation VALUES (@code,@matricule,@nom,@postnom,@prenom,@sexe,@numerosemaine,@datecotise,@dateconcern,@designation,@montant,@usersession,GETDATE(),'Insertion')
END
GO
CREATE TRIGGER InsertHistoriqueModificationCotisation ON Cotisation for UPDATE 
AS
BEGIN
	DECLARE @code int;
	DECLARE @ref_inscrit int;
	DECLARE @ref_semaine int;
	DECLARE @datecotise datetime;
	DECLARE @dateconcern Date;
	DECLARE @ref_frais int;
	DECLARE @montant float;
	DECLARE @usersession VARCHAR(30)

	SELECT @code = Id from inserted
	SELECT @datecotise = Date_Cotisation from inserted
	SELECT @dateconcern = Date_Concernee from inserted
	SELECT @montant = Montant from inserted
	SELECT @usersession = UserSession from inserted

	DECLARE @matricule VARCHAR(30);
	SELECT @matricule = Matricule from Membre WHERE Id=(SELECT Ref_Membre From Inscription WHERE Id=@ref_inscrit)
	DECLARE @nom VARCHAR(50);
	SELECT @nom = Nom from Membre WHERE Id=(SELECT Ref_Membre From Inscription WHERE Id=@ref_inscrit)
	DECLARE @postnom VARCHAR(50);
	SELECT @postnom = Postnom from Membre WHERE Id=(SELECT Ref_Membre From Inscription WHERE Id=@ref_inscrit)
	DECLARE @prenom VARCHAR(50);
	SELECT @prenom = Postnom from Membre WHERE Id=(SELECT Ref_Membre From Inscription WHERE Id=@ref_inscrit)
	DECLARE @sexe VARCHAR;
	SELECT @sexe = Sexe from Membre WHERE Id=(SELECT Ref_Membre From Inscription WHERE Id=@ref_inscrit)
	DECLARE @numerosemaine int;
	SELECT @numerosemaine = Numero From Semaine Where Id=@ref_semaine
	DECLARE @designation VARCHAR(50);
	SELECT @designation = Designation from Type_Frais WHERE Id=@ref_frais

	INSERT INTO Historique_Cotisation VALUES (@code,@matricule,@nom,@postnom,@prenom,@sexe,@numerosemaine,@datecotise,@dateconcern,@designation,@montant,@usersession,GETDATE(),'Modification')
END
GO
CREATE TRIGGER InsertHistoriqueSuppressionCotisation ON Cotisation for DELETE 
AS
BEGIN
	DECLARE @code int;
	DECLARE @ref_inscrit int;
	DECLARE @ref_semaine int;
	DECLARE @datecotise datetime;
	DECLARE @dateconcern Date;
	DECLARE @ref_frais int;
	DECLARE @montant float;
	DECLARE @usersession VARCHAR(30)

	SELECT @code = Id from deleted
	SELECT @datecotise = Date_Cotisation from deleted
	SELECT @dateconcern = Date_Concernee from deleted
	SELECT @montant = Montant from deleted
	SELECT @usersession = UserSession from deleted

	DECLARE @matricule VARCHAR(30);
	SELECT @matricule = Matricule from Membre WHERE Id=(SELECT Ref_Membre From Inscription WHERE Id=@ref_inscrit)
	DECLARE @nom VARCHAR(50);
	SELECT @nom = Nom from Membre WHERE Id=(SELECT Ref_Membre From Inscription WHERE Id=@ref_inscrit)
	DECLARE @postnom VARCHAR(50);
	SELECT @postnom = Postnom from Membre WHERE Id=(SELECT Ref_Membre From Inscription WHERE Id=@ref_inscrit)
	DECLARE @prenom VARCHAR(50);
	SELECT @prenom = Postnom from Membre WHERE Id=(SELECT Ref_Membre From Inscription WHERE Id=@ref_inscrit)
	DECLARE @sexe VARCHAR;
	SELECT @sexe = Sexe from Membre WHERE Id=(SELECT Ref_Membre From Inscription WHERE Id=@ref_inscrit)
	DECLARE @numerosemaine int;
	SELECT @numerosemaine = Numero From Semaine Where Id=@ref_semaine
	DECLARE @designation VARCHAR(50);
	SELECT @designation = Designation from Type_Frais WHERE Id=@ref_frais

	INSERT INTO Historique_Cotisation VALUES (@code,@matricule,@nom,@postnom,@prenom,@sexe,@numerosemaine,@datecotise,@dateconcern,@designation,@montant,@usersession,GETDATE(),'Suppression')
END


