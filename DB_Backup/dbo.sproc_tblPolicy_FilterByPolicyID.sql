CREATE PROCEDURE [sproc_tblPolicy_FilterByPolicyID]
	@PolicyId int
AS
	SELECT * from tblPolicy where PolicyId = @PolicyId
RETURN 0