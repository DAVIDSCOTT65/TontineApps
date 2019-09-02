CREATE TABLE [dbo].[agent](
	[idagent] [int] NOT NULL,
	[noms] [varchar](100) NULL,
	[adresse] [varchar](100) NULL,
	[contact] [varchar](100) NULL,
	[pseudo] [varchar](50) NULL,
	[pass_word] [varchar](200) NULL,
	[niveau_acces] [varchar](10) NULL,
	[sexe] [varchar](1) NULL,
	[email] [varchar](30) NULL,
	[fonction] [varchar](30) NULL,
	[photo] [image] NULL,
 CONSTRAINT [PK__agent__804FB71BB7D51C35] PRIMARY KEY CLUSTERED 
(
	[idagent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [unique_agent] UNIQUE NONCLUSTERED 
(
	[noms] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [unique_pseudo] UNIQUE NONCLUSTERED 
(
	[pseudo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
--------------------------------------------------------------------------------------------------------------------------------------------
CREATE proc [dbo].[INSERT_AGENT](
	@id int,
	@noms varchar(100),
	@adresse varchar(100),
	@contact varchar (100),
	@pseudo varchar (50),
	@password varchar (200),
	@nivau varchar (10),
	@sexe varchar,
	@email varchar(30),
	@fonction varchar(30),
	@photo image
) as begin 
		merge INTo  agent using(values(@id ,@noms, @adresse ,@contact, @pseudo, @password, @nivau, @sexe, @email, @fonction, @photo)) AS nelsON (a,b,c,d,e,f,g,h,i,j,k) ON agent.idagent=nelsON.a
							when matched then
			    update set noms=nelsON.b, adresse=nelson.c,contact=nelson.d,pseudo=nelson.e,niveau_acces=nelson.g,sexe=nelson.h,email=nelson.i,fonction=nelson.j,photo=nelson.k
						when not matched then

				insert  values(a,b,c,d,e,hAShbytes('sha2_512',nelsON.f),g,h,i,j,k);
	end
---------------------------------------------------------------------------------------------------------------------------------------------
GO
CREATE proc [dbo].[SELECT_AGENT]
as
	begin
		select idagent,noms,Sexe,adresse,contact,email,fonction,pseudo,niveau_acces, pass_word, Photo from agent
	end
-----------------------------------------------------------------------------------------------------------------------------------------------
GO
CREATE PROCEDURE [dbo].[SP_Login]
(
@pseudo VARCHAR(50),
@pass VARCHAR(200)
)
	AS
	BEGIN
		SELECT noms,pass_word,niveau_acces FROM agent WHERE pseudo=@pseudo
		 AND pass_word=HASHBYTES('SHA2_512',@pass)

	END
