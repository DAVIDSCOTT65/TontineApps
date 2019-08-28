GO
ALTER VIEW Affichage_Details_Adresse_Membre AS
SELECT m.Id,m.Matricule,m.Nom,m.Postnom,m.Prenom,m.sexe,m.Date_Naissance,m.Lieu_Naissance,m.Profession,m.QrCode,m.Photo,ma.Id As IdMandataire,ma.Noms,ma.Contact,a.Id as IdAdresse,a.Pays,a.Ville,a.Commune,a.Quartier,d.Id as IdDomicile,d.Avenue,d.Numero FROM Domicile as d
INNER JOIN Membre as m ON d.Ref_membre=m.Id
INNER JOIN Adresse as a ON d.Ref_Adresse=a.Id
INNER JOIN Mandataire as ma ON m.Ref_Mandataire=ma.Id

GO
CREATE VIEW Affichage_Details_Inscriptions AS
SELECT i.Id,i.Date_Inscription,m.Id as IdMembre,m.Matricule,m.Nom,m.Postnom,m.Prenom,m.Sexe,r.Id as IdRound,r.Designation FROM Inscription as i
INNER JOIN Affichage_Details_Adresse_Membre as m ON i.Ref_Membre=m.Id
INNER JOIN TRound as r ON i.Ref_Round=r.Id
GO
CREATE VIEW Affichage_Details_Rounds AS
SELECT r.Id,r.Designation,r.Date_Debut,r.Date_Fin,d.Id as IdDetail,d.Montant_Jour,d.Devise,d.Ecart_Jour,d.Limite FROM TRound as r
INNER JOIN Detail_Round as d ON r.Ref_Detail=d.Id
GO
CREATE VIEW Affichage_Details_Cotisation AS
SELECT c.Id,c.Date_Cotisation,c.Date_Concernee,c.Montant,i.Id as IdInscription,i.IdRound,i.Matricule,i.Nom,i.Postnom,i.Prenom,i.Sexe,s.Id as IdSemaine,f.Id as IdFrais,f.Designation FROM Cotisation AS c
INNER JOIN Affichage_Details_Inscriptions as i ON c.Ref_Inscription=i.Id
INNER JOIN Semaine as s ON c.Ref_Semaine=s.Id
INNER JOIN Type_Frais as f ON c.Ref_Frais=f.Id
GO
CREATE VIEW Affichage_Details_Remboursement AS
SELECT r.Id,i.Id as IdInscription,i.IdRound,i.Matricule,i.Nom,i.Postnom,i.Prenom,i.Sexe,s.Id as IdSemaine FROM Remboursement AS r
INNER JOIN Affichage_Details_Inscriptions as i ON r.Ref_Inscription=i.Id
INNER JOIN Semaine as s ON r.Ref_Semaine=s.Id
GO
CREATE VIEW Affichage_Details_Semaine AS
SELECT s.Id,s.Date_Debut,s.Date_Fin,d.Id as IdDetail,d.Montant_Jour,d.Devise,i.Id as IdInscrit,i.IdRound,i.Matricule,i.Nom,i.Postnom,i.Prenom,i.Sexe FROM Semaine AS s
INNER JOIN Detail_Round as d ON s.RefDetail=d.Id
INNER JOIN Affichage_Details_Inscriptions as i ON s.RefInscription=i.Id



