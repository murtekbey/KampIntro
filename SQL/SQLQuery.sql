-- Select
-- ANSII (MySQL, Oracle, PostgreSQL, MSSQL)
SELECT ContactName Adı, CompanyName SirketAdi, City Sehir FROM Customers

SELECT * FROM Customers where City = 'London'

SELECT * FROM Products where categoryId=1 or categoryId=3

SELECT * FROM Products where categoryId=1 and UnitPrice>=10

SELECT * FROM Products ORDER BY UnitPrice desc --ascending(asc) --descending(desc)

SELECT count(*) Adet from Products

-- Hangi kategoride kaç farklı ürünümüz var? 
SELECT CategoryId, count(*) FROM Products GROUP BY CategoryId -- Bütün kategorileri bana tekrar etmicek şekilde listele ve kategoilerde bulunan ürün sayısını listele.
-- Örneğin; Hangi kategorilerde az ürünümüz varsa, o kategoriyi ürünlerle besleyelim ¿

-- Ürün sayısı 10'dan az olan kategorileri listele
SELECT CategoryId, count(*) ÜrünSayısı FROM Products GROUP BY CategoryId having count(*)<10

-- Birim fiyatı 20 den fazla olan ürünleri CategoryId ye göre grupla onlardanda sayısı her bi gruptan 10dan az olanları listele.
SELECT CategoryId, count(*) ÜrünSayısı FROM Products WHERE UnitPrice>20 GROUP BY CategoryId having count(*)<10

-- Products tablosundaki CategoryId ile Categories tablosundaki CategoryId ile eşleşen ürünleri seçtiğim kolonlara göre getir. (Ürün fiyatı 10'dan büyük olanlar) (Fiyatı Artandan Azalana Göre Sırala)
SELECT Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName FROM Products INNER JOIN Categories
ON Products.CategoryId = Categories.CategoryId WHERE Products.UnitPrice>10 ORDER BY UnitPrice

--DTO Data Transformation Object

SELECT * FROM Products p INNER JOIN [Order Details] od -- INNER JOIN Sadece eşleşen kayıtları getirir.
ON p.ProductId = od.ProductId

SELECT * FROM Products p LEFT JOIN [Order Details] od -- solda olup sağda olmayanları da getir
ON p.ProductId = od.ProductId

SELECT * FROM Customers c LEFT JOIN Orders o
ON c.CustomerID = o.CustomerID

-- Sistemimize kayıt olmuş ama hiç sipariş vermemiş müşterileri getir.
SELECT * FROM Customers c LEFT JOIN Orders o
ON c.CustomerID = o.CustomerID
WHERE o.CustomerId is null -- 2 sonuç geldi ve bunlar hiç sipariş vermemiş. Biz bunlara kampanya gönderebiliriz.

SELECT * FROM Products p INNER JOIN [Order Details] od
ON p.ProductId = od.ProductId
INNER JOIN Orders o
ON o.OrderId = od.OrderID -- 3. bir tabloyu bu şekilde join edebiliriz.