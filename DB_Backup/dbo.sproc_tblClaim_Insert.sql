CREATE PROCEDURE [dbo].[sproc_tblClaim_Insert]
    @CustomerID  int,
    @StaffID     int,
    @ClaimReason varchar(50),
    @ClaimDate   date,
    @ClaimAmnt   decimal (8, 2),
    @ClaimStatus bit
AS
	INSERT INTO dbo.tblClaim
	(
	    CustomerID,
	    StaffID,
	    ClaimReason,
	    ClaimDate,
	    ClaimAmnt,
	    ClaimStatus
	)
	VALUES
	(   @CustomerID,
	    @StaffID,
	    @ClaimReason,
	    @ClaimDate,
	    @ClaimAmnt,
	    @ClaimStatus
	    )
RETURN @@IDENTITY