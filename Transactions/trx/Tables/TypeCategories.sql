CREATE TABLE [trx].[TypeCategories] (
    [ID_TRX_TYPE_FK] INT            NULL,
    [CATEGORY_FK]    VARCHAR (255)  NULL,
    [PERCENTAGE]     DECIMAL (5, 2) NOT NULL,
    [ID_TYP_CAT]     INT            IDENTITY (1, 1) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_TYP_CAT] ASC),
    FOREIGN KEY ([CATEGORY_FK]) REFERENCES [trx].[Categories] ([CATEGORY]),
    FOREIGN KEY ([ID_TRX_TYPE_FK]) REFERENCES [trx].[Transaction_Type] ([ID_TRX_TYPE])
);



