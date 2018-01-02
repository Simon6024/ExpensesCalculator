CREATE TABLE [trx].[Transactions] (
    [DATE]             DATETIME      NOT NULL,
    [ACCOUNT_FK]       VARCHAR (255) NOT NULL,
    [AMOUNT]           MONEY         NOT NULL,
    [COMMENT]          VARCHAR (255) NULL,
    [ID_TRX_TYPE_FK]   INT           NULL,
    [SOURCE_FK]        VARCHAR (255) NOT NULL,
    [ID_TRX]           INT           IDENTITY (1, 1) NOT NULL,
    [TYPE_FROM_SOURCE] BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_TRX] ASC),
    FOREIGN KEY ([ACCOUNT_FK]) REFERENCES [trx].[Accounts] ([ACCOUNT]),
    FOREIGN KEY ([ID_TRX_TYPE_FK]) REFERENCES [trx].[Transaction_Type] ([ID_TRX_TYPE]),
    FOREIGN KEY ([SOURCE_FK]) REFERENCES [trx].[Source] ([NAME])
);



