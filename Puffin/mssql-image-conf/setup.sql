CREATE TABLE [dbo].[Feathers] (
    [Id]      UNIQUEIDENTIFIER NOT NULL,
    [Name]    NVARCHAR (50)    CONSTRAINT [DEFAULT_Feathers_Name] DEFAULT (NULL) NULL,
    [Weight]  INT              CONSTRAINT [DEFAULT_Feathers_Weight] DEFAULT (NULL) NULL,
    [Price]   INT              CONSTRAINT [DEFAULT_Feathers_Price] DEFAULT (NULL) NULL,
    [InStock] BIT              CONSTRAINT [DEFAULT_Feathers_InStock] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Feathers] PRIMARY KEY CLUSTERED ([Id] ASC)
);
