CREATE TABLE [trx].[TypeCategories] (
    [ID_TRX_TYPE] INT            NULL,
    [CATEGORY]    VARCHAR (255)  NULL,
    [PERCENTAGE]  DECIMAL (5, 2) NOT NULL,
    FOREIGN KEY ([CATEGORY]) REFERENCES [trx].[Categories] ([CATEGORY]),
    FOREIGN KEY ([ID_TRX_TYPE]) REFERENCES [trx].[Transaction_Type] ([ID_TRX_TYPE])
);

