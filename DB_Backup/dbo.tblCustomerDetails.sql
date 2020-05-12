CREATE TABLE [dbo].[tblCustomerDetails] (
    [CustomerId]            INT  DEFAULT ((0)) NOT NULL,
    [Name ]                 TEXT NOT NULL,
    [DoB]                   DATE NOT NULL,
    [Address]               TEXT NOT NULL,
    [E-mail]                TEXT NULL,
    [Contact Number]        TEXT NULL,
    [Marketing Preferences] BIT  DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

