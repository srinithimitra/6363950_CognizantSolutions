SELECT * FROM(
SELECT
ProductID,
ProductName,
Category,
Price,
DENSE_RANK() OVER(
PARTITION BY Category
ORDER BY Price DESC
)AS Product_DRank
FROM Products
)AS rankedProducts
WHERE Product_DRank<=3