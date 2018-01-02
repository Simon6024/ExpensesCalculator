CREATE TABLE [trx].[Source] (
    [NAME]           VARCHAR (255) NOT NULL,
    [ID_TRX_TYPE_FK] INT           NULL,
    CONSTRAINT [PK_Source] PRIMARY KEY CLUSTERED ([NAME] ASC),
    FOREIGN KEY ([ID_TRX_TYPE_FK]) REFERENCES [trx].[Transaction_Type] ([ID_TRX_TYPE])
);



