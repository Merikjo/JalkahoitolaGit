﻿CREATE TABLE [dbo].[Varauskalenteri] (
    [Varaus_ID]      INT  IDENTITY (1, 1) NOT NULL,
    [Päivämäärä]     DATE NULL,
    [Varausaika]     DATE NULL,
    [Asiakas_id]     INT  NULL,
    [Palvelu_id]     INT  NULL,
    [Puhelin_id]     INT  NULL,
    [Hoitopaikka_id] INT  NULL,
    [Hoitaja_id]     INT  NULL,
    PRIMARY KEY CLUSTERED ([Varaus_ID] ASC),
    CONSTRAINT [FK_Varauskalenteri_ToTable_3] FOREIGN KEY ([Hoitopaikka_id]) REFERENCES [dbo].[Hoitopaikat] ([Hoitopaikka_ID]),
    CONSTRAINT [FK_Varauskalenteri_ToTable] FOREIGN KEY ([Asiakas_id]) REFERENCES [dbo].[Asiakkaat] ([Asiakas_ID]),
    CONSTRAINT [FK_Varauskalenteri_ToTable_4] FOREIGN KEY ([Hoitaja_id]) REFERENCES [dbo].[Hoitajat] ([Hoitaja_ID]),
    CONSTRAINT [FK_Varauskalenteri_ToTable_1] FOREIGN KEY ([Palvelu_id]) REFERENCES [dbo].[Palvelut] ([Palvelu_ID]),
    CONSTRAINT [FK_Varauskalenteri_ToTable_2] FOREIGN KEY ([Puhelin_id]) REFERENCES [dbo].[Puhelin] ([Puhelin_ID])
);

