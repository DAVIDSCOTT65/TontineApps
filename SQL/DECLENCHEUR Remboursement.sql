CREATE TABLE Historique_Remboursements
(
	Id int primary key identity (1,1),
	Numero int,
	Date_Debut Date,
	Date_Fin Date,
	Nom VARCHAR(50),
	Postnom VARCHAR(50),
	Prenom VARCHAR(50),
	Sexe VARCHAR,
	Designation_Round VARCHAR(100),
	Montant float,
	Date_opération dateTime,
	UserSession VARCHAR(30),
	Date_Mis_à_jour dateTime,
	ActionUser VARCHAR(100)
)
SELECT * FROM Historique_Remboursements
GO
CREATE TRIGGER InsertHistoriqueRemboursement ON Remboursement for INSERT 
AS 
BEGIN
	declare @id int;
	declare @refsemaine int;
	declare @montant float;
	declare @dateremb date;
	declare @usersession varchar(50)

	SELECT @id = Id from inserted
	SELECT @refsemaine = Ref_Semaine from inserted
	SELECT @montant = Montant from inserted
	SELECT @dateremb = Date_Remboursement from inserted
	SELECT @usersession = UserSession from inserted

	DECLARE @datedb date;
	SELECT @datedb = Date_Debut from Semaine Where Id=@refsemaine
	DECLARE @datefin date;
	SELECT @datefin = Date_Fin from Semaine Where Id=@refsemaine
	DECLARE @nom VARCHAR(100);
	SELECT @nom = Nom From Membre WHERE Id=(SELECT Ref_Membre FROM Inscription WHERE Id=(SELECT RefInscription FROM Semaine WHERE Id=@refsemaine))
	DECLARE @postnom VARCHAR(100)
	SELECT @postnom = Postnom From Membre WHERE Id=(SELECT Ref_Membre FROM Inscription WHERE Id=(SELECT RefInscription FROM Semaine WHERE Id=@refsemaine))
	DECLARE @prenom VARCHAR(100);
	SELECT @prenom = Prenom From Membre WHERE Id=(SELECT Ref_Membre FROM Inscription WHERE Id=(SELECT RefInscription FROM Semaine WHERE Id=@refsemaine))
	DECLARE @sex VARCHAR;
	SELECT @sex = Sexe From Membre WHERE Id=(SELECT Ref_Membre FROM Inscription WHERE Id=(SELECT RefInscription FROM Semaine WHERE Id=@refsemaine))
	DECLARE @round VARCHAR(100);
	SELECT @round = Designation From TRound WHERE Id=(SELECT RefRound From Semaine WHERE Id=@refsemaine)

	INSERT INTO Historique_Remboursements VALUES (@id,@datedb,@datefin,@nom,@postnom,@prenom,@sex,@round,@montant,@dateremb,@usersession,GETDATE(),'Insertion')
END
GO
CREATE TRIGGER UpdateHistoriqueRemboursement ON Remboursement for UPDATE 
AS 
BEGIN
	declare @id int;
	declare @refsemaine int;
	declare @montant float;
	declare @dateremb date;
	declare @usersession varchar(50)

	SELECT @id = Id from inserted
	SELECT @refsemaine = Ref_Semaine from inserted
	SELECT @montant = Montant from inserted
	SELECT @dateremb = Date_Remboursement from inserted
	SELECT @usersession = UserSession from inserted

	DECLARE @datedb date;
	SELECT @datedb = Date_Debut from Semaine Where Id=@refsemaine
	DECLARE @datefin date;
	SELECT @datefin = Date_Fin from Semaine Where Id=@refsemaine
	DECLARE @nom VARCHAR(100);
	SELECT @nom = Nom From Membre WHERE Id=(SELECT Ref_Membre FROM Inscription WHERE Id=(SELECT RefInscription FROM Semaine WHERE Id=@refsemaine))
	DECLARE @postnom VARCHAR(100)
	SELECT @postnom = Postnom From Membre WHERE Id=(SELECT Ref_Membre FROM Inscription WHERE Id=(SELECT RefInscription FROM Semaine WHERE Id=@refsemaine))
	DECLARE @prenom VARCHAR(100);
	SELECT @prenom = Prenom From Membre WHERE Id=(SELECT Ref_Membre FROM Inscription WHERE Id=(SELECT RefInscription FROM Semaine WHERE Id=@refsemaine))
	DECLARE @sex VARCHAR;
	SELECT @sex = Sexe From Membre WHERE Id=(SELECT Ref_Membre FROM Inscription WHERE Id=(SELECT RefInscription FROM Semaine WHERE Id=@refsemaine))
	DECLARE @round VARCHAR(100);
	SELECT @round = Designation From TRound WHERE Id=(SELECT RefRound From Semaine WHERE Id=@refsemaine)

	INSERT INTO Historique_Remboursements VALUES (@id,@datedb,@datefin,@nom,@postnom,@prenom,@sex,@round,@montant,@dateremb,@usersession,GETDATE(),'Modification')
END
GO
CREATE TRIGGER DeleteHistoriqueRemboursement ON Remboursement for DELETE 
AS 
BEGIN
	declare @id int;
	declare @refsemaine int;
	declare @montant float;
	declare @dateremb date;
	declare @usersession varchar(50)

	SELECT @id = Id from deleted
	SELECT @refsemaine = Ref_Semaine from deleted
	SELECT @montant = Montant from deleted
	SELECT @dateremb = Date_Remboursement from deleted
	SELECT @usersession = UserSession from deleted

	DECLARE @datedb date;
	SELECT @datedb = Date_Debut from Semaine Where Id=@refsemaine
	DECLARE @datefin date;
	SELECT @datefin = Date_Fin from Semaine Where Id=@refsemaine
	DECLARE @nom VARCHAR(100);
	SELECT @nom = Nom From Membre WHERE Id=(SELECT Ref_Membre FROM Inscription WHERE Id=(SELECT RefInscription FROM Semaine WHERE Id=@refsemaine))
	DECLARE @postnom VARCHAR(100)
	SELECT @postnom = Postnom From Membre WHERE Id=(SELECT Ref_Membre FROM Inscription WHERE Id=(SELECT RefInscription FROM Semaine WHERE Id=@refsemaine))
	DECLARE @prenom VARCHAR(100);
	SELECT @prenom = Prenom From Membre WHERE Id=(SELECT Ref_Membre FROM Inscription WHERE Id=(SELECT RefInscription FROM Semaine WHERE Id=@refsemaine))
	DECLARE @sex VARCHAR;
	SELECT @sex = Sexe From Membre WHERE Id=(SELECT Ref_Membre FROM Inscription WHERE Id=(SELECT RefInscription FROM Semaine WHERE Id=@refsemaine))
	DECLARE @round VARCHAR(100);
	SELECT @round = Designation From TRound WHERE Id=(SELECT RefRound From Semaine WHERE Id=@refsemaine)

	INSERT INTO Historique_Remboursements VALUES (@id,@datedb,@datefin,@nom,@postnom,@prenom,@sex,@round,@montant,@dateremb,@usersession,GETDATE(),'Suppression')
END

select * from Remboursement