CREATE TABLE [dbo].[tblPolicy] (
    [PolicyId]      INT            IDENTITY (1, 1) NOT NULL,
    [StaffId]       INT            NOT NULL,
    [CustomerId]    INT            NOT NULL,
    [StartDate]     DATE           NOT NULL,
    [PolicyDetails] TEXT           NULL,
    [Accepted]      BIT            NOT NULL,
    [Price]         DECIMAL (8, 2) NOT NULL,
    CONSTRAINT [PK_tblPolicy] PRIMARY KEY CLUSTERED ([PolicyId] ASC)
);

