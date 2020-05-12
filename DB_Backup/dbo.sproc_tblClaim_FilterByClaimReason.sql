CREATE PROCEDURE [dbo].[sproc_tblClaim_FilterByClaimReason]
    @ClaimReason varchar(50)
AS
	SELECT * FROM dbo.tblClaim WHERE ClaimReason LIKE @ClaimReason+'%';