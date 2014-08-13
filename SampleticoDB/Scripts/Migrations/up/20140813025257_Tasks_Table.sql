SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;

GO
PRINT N'Creating [dbo].[Tasks]...';

GO
CREATE TABLE [dbo].[Tasks] (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [Note]             NVARCHAR (MAX) NOT NULL,
    [Priority]         INT            NOT NULL,
    [CreatedByUserId]  INT            NOT NULL,
    [AssignedToUserId] INT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

GO
PRINT N'Creating [dbo].[FK_Tasks_ToCreatedByUsers]...';


GO
ALTER TABLE [dbo].[Tasks] WITH NOCHECK
    ADD CONSTRAINT [FK_Tasks_ToCreatedByUsers] FOREIGN KEY ([CreatedByUserId]) REFERENCES [dbo].[Users] ([Id]);


GO
PRINT N'Creating [dbo].[FK_Tasks_ToAssignedToUsers]...';


GO
ALTER TABLE [dbo].[Tasks] WITH NOCHECK
    ADD CONSTRAINT [FK_Tasks_ToAssignedToUsers] FOREIGN KEY ([AssignedToUserId]) REFERENCES [dbo].[Users] ([Id]);

GO
PRINT N'Checking existing data against newly created constraints';


GO
ALTER TABLE [dbo].[Tasks] WITH CHECK CHECK CONSTRAINT [FK_Tasks_ToCreatedByUsers];

ALTER TABLE [dbo].[Tasks] WITH CHECK CHECK CONSTRAINT [FK_Tasks_ToAssignedToUsers];

GO
