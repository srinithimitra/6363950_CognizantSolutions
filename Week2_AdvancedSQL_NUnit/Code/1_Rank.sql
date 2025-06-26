SELECT * FROM(
SELECT
ProductID,
ProductName,
Category,
Price,
RANK() OVER(
PARTITION BY Category
ORDER BY Price DESC
)AS Product_Rank
FROM Products
)AS rankedProducts
WHERE Product_Rank<=3


