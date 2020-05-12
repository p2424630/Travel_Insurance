CREATE PROCEDURE [dbo].[sproc_tblPolicy_Update]
--create parameters for stored procedure
	@PolicyId int,
	@StaffId int,
	@CustomerId int,
	@StartDate date,
	@PolicyDetails text,
	@Accepted bit,
	@Price decimal(8,2)
AS
	UPDATE dbo.tblPolicy
	SET
	    CustomerId = @CustomerId,
	    StaffId =  @StaffId,
	    PolicyDetails = @PolicyDetails,
	    StartDate = @StartDate,
	    Price = @Price,
	    Accepted = @Accepted
	WHERE PolicyId = @PolicyId