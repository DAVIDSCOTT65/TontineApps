
GO
CREATE TRIGGER [dbo].[InsertMatricule] ON [dbo].[Inscription] after INSERT 
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

	update Membre set Matricule=(select SUBSTRING(@nom,3,2))+(select SUBSTRING(@round,0,3))+''+(select SUBSTRING(@postnom,0,2))+''+'00'+(select CONVERT(nvarchar(100),@refmembre))
	where id=@refmembre

END