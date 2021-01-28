--Her bir üründen toplamda ne kadar para kazandığımızı bulunuz.
--İpucu : Group by kullanılacak
--İpucu : Products, Orders, Order Details tabloları join edilecek.
--İpucu : Sum kullanılacak.
--Sonuç aşağıdaki formatta olmalıdır.
--Ürün Adı, Kazanılan Toplam Miktar

--Not : Kazanılan tutar toplamı Order Details tablosunda unitPrice ve quantity alanlarının çarpımından beslenecek.
--Ödevinize ait sql kodunu paylaşınız.

SELECT p.ProductName [Ürün Adı], 
SUM(od.UnitPrice*od.Quantity) [Kazanılan Toplam Miktar]
FROM Products AS p
INNER JOIN [Order Details] AS od
ON p.ProductID = od.ProductID
INNER JOIN Orders o
ON od.OrderID = o.OrderID
GROUP BY p.ProductName
ORDER BY [Kazanılan Toplam Miktar] DESC

-- Sorguyu test etmek isterseniz Northwind DB kullanılarak hazırlanmıştır.