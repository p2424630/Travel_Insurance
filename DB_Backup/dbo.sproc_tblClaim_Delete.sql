CREATE PROCEDURE [dbo].[sproc_tblClaim_Delete]
    @ClaimID int
AS
	DELETE FROM dbo.tblClaim WHERE ClaimID = @ClaimID;