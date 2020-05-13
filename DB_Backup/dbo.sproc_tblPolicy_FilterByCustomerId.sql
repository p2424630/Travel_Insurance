CREATE PROCEDURE [dbo].[sproc_tblPolicy_FilterByCustomerId]
	@CustomerId varchar(50)
AS
	select * from tblPolicy where CustomerId like @CustomerId+'%';