CREATE TABLE [dbo].[Users] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Email]        NVARCHAR (500) NOT NULL,
    [Password]     NVARCHAR (255) NOT NULL,
    [PasswordSalt] NVARCHAR (255) NOT NULL,
    [IsAdmin]      BIT            NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);

