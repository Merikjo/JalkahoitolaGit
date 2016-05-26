CREATE TABLE [dbo].[Henkilokunta] (
    [Henkilokunta_ID]       INT            IDENTITY (1, 1) NOT NULL,
    [Etunimi]          NVARCHAR (20)  NULL,
    [Sukunimi]         NVARCHAR (20)  NULL,
    [Katuosoite]       NVARCHAR (100) NULL,
    [Postinumero]      VARCHAR (5)    NULL,
    [Postitoimipaikka] VARCHAR (50)   NULL,
    [Henkilotunnus]    NVARCHAR (20)  NULL,
    [Puhelinnumero_1]  NVARCHAR (20)  NULL,
	[Sahkoposti]		NVARCHAR (100) NULL,
    [Huomiot]          NVARCHAR (200) NULL,
    [Osoite_id]        INT            NULL,
    [Huomio_id]        INT            NULL,
    [Puhelin_id]       INT            NULL,

    PRIMARY KEY CLUSTERED ([Henkilokunta_ID] ASC),
    CONSTRAINT [FK_Henkilokunta_ToTable] FOREIGN KEY ([Osoite_id]) REFERENCES [dbo].[Osoite] ([Osoite_ID]),
    CONSTRAINT [FK_Henkilokunta_ToTable_1] FOREIGN KEY ([Puhelin_id]) REFERENCES [dbo].[Puhelin] ([Puhelin_ID]),
    CONSTRAINT [FK_Henkilokunta_ToTable_2] FOREIGN KEY ([Huomio_id]) REFERENCES [dbo].[Huomiot] ([Huomio_ID])
);