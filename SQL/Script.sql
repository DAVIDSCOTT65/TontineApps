CREATE DATABASE TONTINE_TEST
USE TONTINE_TEST
GO
CREATE TABLE Mandataire
(
	Id int,
	Noms VARCHAR(100),
	Contact VARCHAR(30),
	Profession VARCHAR(30),
	Date_Naiss DATE,
	Constraint pk_mandataire primary key(Id)
)
CREATE TABLE Adresse
(
	Id int,
	Quartier VARCHAR(30),
	Commune VARCHAR(30),
	Ville VARCHAR(30),
	Pays VARCHAR(30),
	Constraint pk_adresse primary key(Id)
)
CREATE TABLE Membre
(
	Id int,
	Matricule VARCHAR(30),
	Nom VARCHAR(50),
	Postnom VARCHAR(50),
	Prenom VARCHAR(50),
	Sexe VARCHAR,
	Date_Naissance Date,
	Lieu_Naissance VARCHAR(30),
	Profession VARCHAR(30),
	QrCode Image,
	Photo Image,
	Ref_Mandataire INT,
	Constraint pk_membre primary key(Id),
	constraint uk_membre unique(nom,postnom,prenom),
	Constraint fk_membre_mandataire
	FOREIGN KEY(Ref_Mandataire) REFERENCES Mandataire(Id)
)
CREATE TABLE Domicile
(
	Id int,
	Avenue VARCHAR(30),
	Numero VARCHAR(10),
	Ref_membre int,
	Ref_Adresse int,
	Constraint pk_domicile primary key(Id),
	Constraint fk_domicile_membre 
	FOREIGN KEY(Ref_membre) REFERENCES Membre(Id),
	Constraint fk_domicile_adresse 
	FOREIGN KEY(Ref_Adresse) REFERENCES Adresse(Id)
)
CREATE TABLE Telephone
(
	Id int,
	Initial VARCHAR(6),
	Numero VARCHAR(20),
	Ref_Membre int,
	Constraint pk_telephone Primary key(Id),
	Constraint fk_telephone_membre
	FOREIGN KEY(Ref_Membre) REFERENCES Membre(Id)
)
CREATE TABLE Detail_Round
(
	Id int,
	Ecart_Jour int,
	Montant_Jour float,
	Devise VARCHAR(20),
	Limite VARCHAR(30),
	User_Session VARCHAR(30),
	Constraint pk_detail_round primary key(Id)
)
CREATE TABLE TRound
(
	Id int,
	Designation VARCHAR(20),
	Date_Debut DATETIME,
	Date_Fin DATETIME,
	Ref_Detail int,
	Constraint pk_round primary key(Id),
	Constraint uk_round UNIQUE(Designation),
	Constraint fk_round_detail
	FOREIGN KEY(Ref_Detail) REFERENCES Detail_Round(Id)
)
CREATE TABLE Inscription
(
	Id int,
	Ref_Membre int,
	Ref_Round int,
	Date_Inscription DATETIME,
	UserSession VARCHAR(30),
	Constraint pk_inscription primary key(Id),
	Constraint uk_inscription_round UNIQUE(Ref_membre,Ref_Round),
	Constraint fk_inscription_membre 
	FOREIGN KEY(Ref_Membre) REFERENCES Membre(Id),
	Constraint fk_inscription_round 
	FOREIGN KEY(Ref_Round) REFERENCES TRound(Id)
)
CREATE TABLE Semaine
(
	Id int,
	Numero int,
	Date_Debut DATE,
	Date_Fin DATE,
	Constraint pk_semaine primary key(Id),
)
ALTER TABLE Semaine
ADD Constraint fk_semaine_detail 
	FOREIGN KEY(Ref_Detail) REFERENCES Detail_Round(Id)
CREATE TABLE Remboursement
(
	Id int,
	Ref_Inscription int,
	Ref_Semaine int,
	Constraint pk_remboursement primary key(Id),
	Constraint fk_rembourse_semaine 
	FOREIGN KEY(Ref_Semaine) REFERENCES Semaine(Id),
	Constraint fk_rembourse_inscription
	FOREIGN KEY(Ref_Semaine) REFERENCES Inscription(Id)
)
CREATE TABLE Type_Frais
(
	Id int,
	Designation VARCHAR(50),
	Constraint pk_categorie primary key(Id),
	Constraint uk_designation UNIQUE(Designation)
)
CREATE TABLE Cotisation
(
	Id int,
	Ref_Inscription int,
	Ref_Semaine int,
	Date_Cotisation DATETIME,
	Date_Concernee Date,
	Ref_Frais int,
	Montant float,
	UserSession VARCHAR(50),
	Constraint pk_cotisation primary key(Id),
	Constraint uk_cotisation UNIQUE(Ref_Inscription,Date_Concernee),
	Constraint fk_cotisation_inscription 
	FOREIGN KEY(Ref_Inscription) REFERENCES Inscription(Id),
	Constraint fk_cotisation_semaine
	FOREIGN KEY(Ref_Semaine) REFERENCES Semaine(Id),
	Constraint fk_cotisation_frais
	FOREIGN KEY(Ref_Frais) REFERENCES Type_Frais(Id)
)

ALTER TABLE Semaine
ADD CONSTRAINT fk_semaine_inscription 
FOREIGN KEY(RefInscription) REFERENCES Inscription(Id)