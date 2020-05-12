CREATE PROCEDURE [dbo].[sproc_tblClaim_Update]
	@ClaimID	 int,
    @CustomerID  int,
    @StaffID     int,
    @ClaimReason varchar(50),
    @ClaimDate   date,
    @ClaimAmnt   decimal (8, 2),
    @ClaimStatus bit
AS
	UPDATE dbo.tblClaim
	SET
	    CustomerID = @CustomerID,
	    StaffID =  @StaffID,
	    ClaimReason = @ClaimReason,
	    ClaimDate = @ClaimDate,
	    ClaimAmnt = @ClaimAmnt,
	    ClaimStatus = @ClaimStatus
	WHERE ClaimID = @ClaimID