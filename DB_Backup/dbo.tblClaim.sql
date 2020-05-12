CREATE TABLE [dbo].[tblClaim] (
    [ClaimID]     INT            IDENTITY (1, 1) NOT NULL,
    [CustomerID]  INT            NOT NULL,
    [StaffID]     INT            NOT NULL,
    [ClaimReason] VARCHAR (50)   NOT NULL,
    [ClaimDate]   DATE           NOT NULL,
    [ClaimAmnt]   DECIMAL (8, 2) NOT NULL,
    [ClaimStatus] BIT            NOT NULL,
    CONSTRAINT [PK_tblClaim] PRIMARY KEY CLUSTERED ([ClaimID] ASC)
);

