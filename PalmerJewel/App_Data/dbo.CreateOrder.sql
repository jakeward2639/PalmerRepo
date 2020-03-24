CREATE PROCEDURE [dbo].[CreateOrder]
	@DateOrdered date,
	@Username varchar(16)
AS
	DECLARE @UserId int
	DECLARE @CurrentOrder int
	DECLARE @retord int

	SELECT @UserId = Id                           
	FROM Users
	WHERE Username = @Username

	SELECT @CurrentOrder = FLOOR(RAND()*(10000-0+1)+0);

	UPDATE Users
	SET CurrentOrder = @CurrentOrder
	WHERE Username = @Username

	SELECT @CurrentOrder = CurrentOrder
	FROM Users
	WHERE Id = @UserId

	INSERT INTO Orders(OrderId, Id, DateOrdered)
	VALUES (@CurrentOrder, @UserId, @DateOrdered)

	SELECT @retord = OrderId
	FROM Orders
	WHERE Id = @UserId
RETURN @retord