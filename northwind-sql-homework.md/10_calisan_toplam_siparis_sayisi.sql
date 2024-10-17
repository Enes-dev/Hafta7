SELECT EmployeeID, COUNT(OrderID) AS TotalOrders
FROM Orders
GROUP BY EmployeeID;