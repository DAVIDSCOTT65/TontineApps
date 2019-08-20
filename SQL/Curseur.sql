USE [TONTINE_TEST]
GO
/****** Object:  StoredProcedure [dbo].[INSERT_INSCRIPTION]    Script Date: 20/08/2019 11:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[INSERT_INSCRIPTION]
(
	@id int,
	@ref_membre int,
	@ref_round int,
	@user_session VARCHAR(20)
)
AS
BEGIN
	if(@id in (SELECT id FROM Inscription))
	BEGIN
		UPDATE Inscription SET Ref_Membre=@ref_membre,Ref_Round=@ref_round,UserSession=@user_session WHERE Id=@id
	END
	Else
	BEGIN
		INSERT INTO Inscription VALUES (@id,@ref_membre,@ref_round,GETDATE(),@user_session)
		exec GENERER_MATRICULE
	END
END
