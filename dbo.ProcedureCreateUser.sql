CREATE PROCEDURE [dbo].[ProcedureCreateUser] @Username varchar, @Password varchar
AS
INSERT INTO Users(Id, Username, Password)
VALUES (0, @Username, @Password);