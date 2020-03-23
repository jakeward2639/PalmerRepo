CREATE PROCEDURE [dbo].[CreateOrder]
	@DateOrdered date,
	@Username varchar(16),
	@UserId int,
	@retord int,
	@CurrentOrder int
AS
	SELECT @UserId = Id
	FROM Users
	WHERE Username = @Username

	SELECT @CurrentOrder = FLOOR(RAND()*(10000-0+1)+0);

	INSERT INTO Users(CurrentOrder)
	SELECT (@CurrentOrder)
	WHERE Username = @Username

	SELECT @CurrentOrder = CurrentOrder
	FROM Users
	WHERE Id = @UserId;

	INSERT INTO Orders(OrderId, Id, DateOrdered)
	VALUES (@CurrentOrder, @UserId, @DateOrdered)

	SELECT @retord = OrderId
	FROM Orders
	WHERE Id = @UserId
RETURN @retord