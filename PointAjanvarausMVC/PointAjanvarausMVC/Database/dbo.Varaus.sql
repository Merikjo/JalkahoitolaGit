﻿CREATE TABLE [dbo].[Varaus] (
    [Varaus_ID]      INT            IDENTITY (1000, 1) NOT NULL,
    [Hoitaja_ID]     INT            NULL,
    [Hoitopaikka_ID] INT            NULL,
    [Asiakas_ID]     INT            NULL,
    [Alku]           NVARCHAR (10)  NULL,
    [Loppu]          NVARCHAR (10)  NULL,
    [Palvelun nimi]  NVARCHAR (100) NULL,
    [Palvelu_ID]     INT            NULL,
    [Info]           NVARCHAR (100) NULL,
    [Type]           INT            NOT NULL,
    [pvm]            DATETIME       NULL,
	[Toimipiste_ID] INT NULL,
    PRIMARY KEY CLUSTERED ([Varaus_ID] ASC),
    CONSTRAINT [FK_Varaus_ToTable] FOREIGN KEY ([Hoitaja_ID]) REFERENCES [dbo].[Hoitajat] ([Hoitaja_ID]),
    CONSTRAINT [FK_Varaus_ToTable_3] FOREIGN KEY ([Palvelu_ID]) REFERENCES [dbo].[Palvelut] ([Palvelu_ID]),
    CONSTRAINT [FK_Varaus_ToTable_1] FOREIGN KEY ([Hoitopaikka_ID]) REFERENCES [dbo].[Hoitopaikat] ([Hoitopaikka_ID]),
    CONSTRAINT [FK_Varaus_ToTable_2] FOREIGN KEY ([Asiakas_ID]) REFERENCES [dbo].[Asiakkaat] ([Asiakas_ID]),
	CONSTRAINT [FK_Varaus_ToTable_4] FOREIGN KEY ([Toimipiste_ID]) REFERENCES [dbo].[Toimipisteet] ([Toimipiste_ID])
);

