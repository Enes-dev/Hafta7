SELECT o.OrderID, SUM(od.UnitPrice * od.Quantity) AS TotalAmount
FROM Orders o
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY o.OrderID;