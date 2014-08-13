CREATE TABLE [RoundhousE].[ScriptsRunErrors] (
    [id]                       BIGINT         IDENTITY (1, 1) NOT NULL,
    [repository_path]          NVARCHAR (255) NULL,
    [version]                  NVARCHAR (50)  NULL,
    [script_name]              NVARCHAR (255) NULL,
    [text_of_script]           NTEXT          NULL,
    [erroneous_part_of_script] NTEXT          NULL,
    [error_message]            NTEXT          NULL,
    [entry_date]               DATETIME       NULL,
    [modified_date]            DATETIME       NULL,
    [entered_by]               NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

