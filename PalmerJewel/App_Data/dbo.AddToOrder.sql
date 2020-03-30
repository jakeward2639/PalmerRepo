CREATE PROCEDURE [dbo].[AddToOrder]
	@OrderId int,
	@ProductName varchar(50),
	@Quantity int
AS
	

	INSERT INTO OrderDetails(OrderId, ProductId, Quantity, Total)
	VALUES(@OrderId, @ProductId, @Quantity, @Total);