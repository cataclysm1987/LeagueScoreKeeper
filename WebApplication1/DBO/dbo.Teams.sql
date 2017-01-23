CREATE TABLE [dbo].[Teams] (
    [TeamId]          INT            IDENTITY (1, 1) NOT NULL,
    [StudentName]     NVARCHAR (MAX) NOT NULL,
    [League_LeagueId] INT            NOT NULL,
    CONSTRAINT [PK_dbo.Teams] PRIMARY KEY CLUSTERED ([TeamId] ASC),
    CONSTRAINT [FK_dbo.Teams_dbo.Leagues_League_LeagueId] FOREIGN KEY ([League_LeagueId]) REFERENCES [dbo].[Leagues] ([LeagueId])
);


GO
CREATE NONCLUSTERED INDEX [IX_League_LeagueId]
    ON [dbo].[Teams]([League_LeagueId] ASC);

