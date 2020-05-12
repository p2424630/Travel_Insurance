CREATE PROCEDURE [dbo].[sproc_tblPolicy_Insert]
--create parameters for stored procedure
	@StaffId int,
	@CustomerId int,
	@StartDate date,
	@PolicyDetails text,
	@Accepted bit,
	@Price decimal(6,2)
AS
	--insert new record
	INSERT INTO tblPolicy (StaffId, CustomerId, StartDate, PolicyDetails, Accepted, Price)
	values (@StaffId, @CustomerId, @StartDate, @PolicyDetails, @Accepted, @Price)

	--return the PK value of new record
	return @@Identity