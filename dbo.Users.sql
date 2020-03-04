CREATE TABLE [dbo].[Users] (
    [Id]       INT NOT NULL,
    [Username] CHAR(16) NOT NULL,
    [Password] CHAR(16) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

