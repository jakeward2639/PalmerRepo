CREATE PROCEDURE [dbo].[ProcedureCheckPermissionAdmin] 
(
@Username varchar(16), 
@Password varchar(16)
)
AS
DECLARE @retper varchar(3)
SELECT @retper = Permission
FROM Users
WHERE Username = @Username
AND Password = @Password 
RETURN @retper