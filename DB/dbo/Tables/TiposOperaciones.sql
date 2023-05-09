CREATE TABLE [dbo].[TiposOperaciones] (
    [id]          INT        IDENTITY (1, 1) NOT NULL,
    [Descripcion] NCHAR (50) NOT NULL,
    CONSTRAINT [PK_TiposOperaciones] PRIMARY KEY CLUSTERED ([id] ASC)
);

