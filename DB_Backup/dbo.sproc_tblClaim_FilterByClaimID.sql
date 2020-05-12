CREATE PROCEDURE [dbo].[sproc_tblClaim_FilterByClaimID]
	@ClaimID int
AS
	SELECT * FROM dbo.tblClaim WHERE ClaimID = @ClaimID
RETURN 0