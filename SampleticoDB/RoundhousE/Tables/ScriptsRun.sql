CREATE TABLE [RoundhousE].[ScriptsRun] (
    [id]              BIGINT         IDENTITY (1, 1) NOT NULL,
    [version_id]      BIGINT         NULL,
    [script_name]     NVARCHAR (255) NULL,
    [text_of_script]  TEXT           NULL,
    [text_hash]       NVARCHAR (512) NULL,
    [one_time_script] BIT            NULL,
    [entry_date]      DATETIME       NULL,
    [modified_date]   DATETIME       NULL,
    [entered_by]      NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

