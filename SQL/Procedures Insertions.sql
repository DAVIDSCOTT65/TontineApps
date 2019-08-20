CREATE PROC INSERT_ADRESSE
(
	@id int,
	@quartier varchar(50),
	@commune varchar(50),
	@ville varchar(50),
	@pays varchar(50)
)
AS 
BEGIN
	if(@id in (SELECT id from Adresse))
		update Adresse set Quartier=@quartier,Commune=@commune,Ville=@ville,Pays=@pays WHERE Id=@id
	else
		INSERT INTO Adresse VALUES(@id,@quartier,@commune,@ville,@pays)
END
GO
CREATE PROCEDURE INSERT_DOMICILE
(
	@id int,
	@avenue varchar(50),
	@numero VARCHAR(10),
	@ref_membre int,
	@ref_adresse int
)
as
BEGIN
	if(@id in (SELECT id from Domicile))
		UPDATE Domicile SET Avenue=@avenue,Numero=@numero,Ref_membre=@ref_membre,Ref_Adresse=@ref_adresse WHERE Id=@id
	ELSE
		INSERT INTO Domicile VALUES (@id,@avenue,@numero,@ref_membre,@ref_adresse)
END
GO
CREATE PROC INSERT_MEMBRE
(
	@id int,
	@matricule VARCHAR(30),
	@nom varchar(30),
	@postnom varchar(30),
	@prenom varchar(30),
	@sexe VARCHAR,
	@date_naiss Date,
	@lieu_naiss VARCHAR(30),
	@profession VARCHAR(30),
	@qrcode Image,
	@photo Image,
	@ref_mandataire int
)
AS
BEGIN
	if(@id in (SELECT id FROM Membre))
		UPDATE Membre SET Nom=@nom,Postnom=@postnom,Prenom=@prenom,Sexe=@sexe,Date_Naissance=@date_naiss,Lieu_Naissance=@lieu_naiss,Profession=@profession,QrCode=@qrcode,Photo=@photo,Ref_Mandataire=@ref_mandataire WHERE Id=@id
	Else
		INSERT INTO Membre VALUES (@id,@matricule,@nom,@postnom,@prenom,@sexe,@date_naiss,@lieu_naiss,@profession,@qrcode,@photo,@ref_mandataire)
END
GO
CREATE PROC INSERT_TELEPHONE
(
	@id int,
	@initial varchar(6),
	@numero varchar(10),
	@ref_membre int
)
AS
BEGIN
	if(@id in (SELECT Id from Telephone))
		UPDATE Telephone SET Initial=@initial,Numero=@numero,Ref_Membre=@ref_membre WHERE Id=@id
	Else
		INSERT INTO Telephone VALUES (@id,@initial,@numero,@ref_membre)
END
GO
CREATE PROC INSERT_MANDATAIRE
(
	@id int,
	@noms VARCHAR(100),
	@contact VARCHAR(20),
	@profession VARCHAR(20),
	@date_naiss Date
)
AS
BEGIN
	if(@id in (SELECT Id FROM Mandataire))
		UPDATE Mandataire SET Id=@id,Noms=@noms,Contact=@contact,Profession=@profession,Date_Naiss=@date_naiss WHERE Id=@id
	Else
		INSERT INTO Mandataire VALUES (@id,@noms,@contact,@profession,@date_naiss)
END
GO
CREATE PROC INSERT_INSCRIPTION
(
	@id int,
	@ref_membre int,
	@ref_round int,
	@user_session VARCHAR(20)
)
AS
BEGIN
	if(@id in (SELECT id FROM Inscription))
		UPDATE Inscription SET Ref_Membre=@ref_membre,Ref_Round=@ref_round,UserSession=@user_session WHERE Id=@id
	Else
		INSERT INTO Inscription VALUES (@id,@ref_membre,@ref_round,GETDATE(),@user_session)
END
GO
ALTER PROC INSERT_ROUND
(
	@id int,
	@desination VARCHAR(30),
	@date_debut Date,
	@ref_detail int
)
AS
BEGIN
	DECLARE @nombreJourTontine int;
	SELECT @nombreJourTontine = (SELECT Ecart_Jour*Limite FROM Detail_Round WHERE Id=@ref_detail);
	--SELECT DATEADD(day,@nombreJourTontine,@date_debut) as DateFin;

	if(@id in (SELECT id From TRound))
		UPDATE TRound SET Designation=@desination,Date_Debut=@date_debut,Date_Fin=DATEADD(day,@nombreJourTontine,@date_debut),Ref_Detail=@ref_detail WHERE Id=@id
	Else
		INSERT INTO TRound VALUES (@id,@desination,@date_debut,DATEADD(day,@nombreJourTontine,@date_debut),@ref_detail)
END

GO
CREATE PROC INSERT_DETAIL_ROUND
(
	@id int,
	@ecart int,
	@montant float,
	@devise varchar(15),
	@limite int,
	@usersession varchar(20)
)
AS
BEGIN
		if(@id in (SELECT id FROM Detail_Round))
			UPDATE Detail_Round SET Ecart_Jour=@ecart,Montant_Jour=@montant,Devise=@devise,Limite=@limite,User_Session=@usersession WHERE Id=@id
		ELse
			INSERT INTO Detail_Round VALUES (@id,@ecart,@montant,@devise,@limite,@usersession)
END
GO
CREATE PROC INSERT_REMBOURSEMENT
(
	@id int,
	@ref_inscrit int,
	@ref_semaine int
)
AS
BEGIN
	if(@id in (SELECT id FROM Remboursement))
		UPDATE Remboursement SET Ref_Inscription=@ref_inscrit,Ref_Semaine=@ref_semaine WHERE Id=@id
	Else
		INSERT INTO Remboursement VALUES (@id,@ref_inscrit,@ref_semaine)
END
GO
CREATE PROC INSERT_SEMAINE
(
	@id int,
	@numero int,
	@refdetail int
)
AS
BEGIN
	DECLARE @datedebut date;
	SELECT @datedebut = (SELECT Date_Debut FROM TRound WHERE Ref_Detail=@refdetail);
	DECLARE @ecart int;
	SELECT @ecart = (SELECT Ecart_Jour FROM Detail_Round WHERE Id=@refdetail);
	DECLARE @nbrSemaine int;
	SELECT @nbrSemaine = (SELECT Limite FROM Detail_Round WHERE Id=@refdetail);

	if(@id in (SELECT Id from Semaine))
		UPDATE Semaine Set Numero=@numero,Date_Debut=@datedebut,Date_Fin=DATEADD(day,@ecart,@datedebut),Ref_Detail=@refdetail WHERE Id=@id
	Else if((SELECT max(Id) From Semaine) <= @nbrSemaine)
		INSERT INTO Semaine VALUES (@id,@numero,@datedebut,DATEADD(day,@ecart,@datedebut),@refdetail)

END
GO
CREATE PROC INSERT_TYPE_FRAIS
(
	@id int,
	@designation varchar(50)
)
AS
BEGIN
	if(@id in (SELECT id FROM Type_Frais))
		UPDATE Type_Frais SET Designation=@designation WHERE Id=@id
	ELSE
		INSERT INTO Type_Frais VALUES (@id,@designation)
END
GO
CREATE PROC INSERT_COTISATION
(
	@id int,
	@ref_inscription int,
	@ref_semaine int,
	@date_concerne date,
	@ref_frais int,
	@montant float,
	@usersession varchar(30)
)
AS
BEGIN
	
	if(@id in (SELECT id FROM Cotisation))
		UPDATE Cotisation SET Ref_Inscription=@ref_inscription,Ref_Semaine=@ref_semaine,Date_Concernee=@date_concerne,Ref_Frais=@ref_frais,Montant=@montant, UserSession=@usersession WHERE Id=@id
	Else
		INSERT INTO Cotisation VALUES (@id,@ref_inscription,@ref_semaine,GETDATE(),@date_concerne,@ref_frais,@montant,@usersession)
END
