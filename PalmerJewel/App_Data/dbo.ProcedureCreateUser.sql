CREATE PROCEDURE [dbo].[ProcedureCreateUser] @Username varchar(16), @Password varchar(16)
AS
INSERT INTO Users(Username, Password, Permission)
VALUES (@Username, @Password, '2');