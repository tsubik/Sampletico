CREATE TABLE [RoundhousE].[Version] (
    [id]              BIGINT         IDENTITY (1, 1) NOT NULL,
    [repository_path] NVARCHAR (255) NULL,
    [version]         NVARCHAR (50)  NULL,
    [entry_date]      DATETIME       NULL,
    [modified_date]   DATETIME       NULL,
    [entered_by]      NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

