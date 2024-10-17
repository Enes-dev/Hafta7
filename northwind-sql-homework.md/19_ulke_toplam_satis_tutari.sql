SELECT c.Country, SUM(od.UnitPrice * od.Quantity) AS TotalSales
FROM Orders o
JOIN [Order Details] od ON o.OrderID = od.OrderID
JOIN Customers c ON o.CustomerID = c.CustomerID
GROUP BY c.Country;