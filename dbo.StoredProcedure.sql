CREATE PROCEDURE [dbo].[Информация по заказам]
@dateStart varchar(50),
@dateEnd varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT *
	FROM (SELECT o.Order_ID, o.Date, o.Amount, o.Status, c.Name
	From dbo.Orders AS o
	Join dbo.Customers as c ON (o.Customer_ID = c.ID)
	Where o.Date BETWEEN @dateStart AND @dateEnd) AS A
	INNER JOIN 
	(SELECT (SELECT Title + '; ' 
           FROM (SELECT oi.Order_ID, p.Title 
		   From dbo.Order_Items AS oi
		   Join dbo.Products AS p ON (oi.Product_ID = p.ID)) p2
		   WHERE p2.Order_ID = p1.Order_ID
		   ORDER BY Title
		   FOR XML PATH('') ) AS Products, Order_ID
		FROM dbo.Order_Items AS p1
		GROUP BY Order_ID) AS B
	ON A.Order_ID = B.Order_ID
	ORDER BY A.Date DESC, A.Order_ID DESC
END