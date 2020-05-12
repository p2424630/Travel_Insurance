CREATE PROCEDURE [dbo].[sproc_tblPolicy_Delete]
	--used to delete a single record in the table tblPolicy
	--accepts a single parameter @PolicyId and doesn't return anything

	@PolicyId int
AS
	--delete the record specified by the value of @PolicyId
	DELETE FROM tblPolicy where PolicyId = @PolicyId;