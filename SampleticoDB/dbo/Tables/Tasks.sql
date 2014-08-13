CREATE TABLE [dbo].[Tasks]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Note] NVARCHAR(MAX) NOT NULL, 
    [Priority] INT NOT NULL, 
    [CreatedByUserId] INT NOT NULL, 
    [AssignedToUserId] INT NULL, 
    CONSTRAINT [FK_Tasks_ToCreatedByUsers] FOREIGN KEY ([CreatedByUserId]) REFERENCES [Users]([Id]), 
    CONSTRAINT [FK_Tasks_ToAssignedToUsers] FOREIGN KEY ([AssignedToUserId]) REFERENCES [Users]([Id])
)
