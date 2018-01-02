CREATE TABLE [trx].[Transactions] (
    [DATE]        DATETIME      NOT NULL,
    [ACCOUNT]     VARCHAR (255) NOT NULL,
    [AMOUNT]      MONEY         NOT NULL,
    [COMMENT]     VARCHAR (255) NULL,
    [ID_TRX_TYPE] INT           NULL,
    [NAME]        VARCHAR (255) NOT NULL,
    FOREIGN KEY ([ACCOUNT]) REFERENCES [trx].[Accounts] ([ACCOUNT]),
    FOREIGN KEY ([ID_TRX_TYPE]) REFERENCES [trx].[Transaction_Type] ([ID_TRX_TYPE]),
    FOREIGN KEY ([NAME]) REFERENCES [trx].[Source] ([NAME])
);

