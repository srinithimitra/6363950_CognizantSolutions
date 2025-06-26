USE master;
SELECT * FROM (
SELECT
ProductID,
ProductName,
Category,
Price,
ROW_NUMBER() OVER(
	 PARTITION BY Category
	 ORDER BY Price DESC
 )AS RowNum
 FROM Products)AS rankedProducts
 
 WHERE RowNum<=3
