SELECT p.ProductName, SUM(od.Quantity) AS TotalSold
FROM Products p
JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductName
ORDER BY TotalSold DESC
LIMIT 5;