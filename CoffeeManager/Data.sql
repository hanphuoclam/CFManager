DROP DATABASE CFM
GO
CREATE DATABASE CFM
GO
USE CFM
GO

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) DEFAULT N'Chưa đặt tên',
	status NVARCHAR(100) DEFAULT N'Trống' --trống || có khách || đã đặt 
)
GO

CREATE TABLE ProductCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Product
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) DEFAULT N'Chưa đặt tên',
	price FLOAT DEFAULT 0,
	inventory INT DEFAULT 0,
	idCategory int NOT NULL,
	FOREIGN KEY (idCategory) REFERENCES dbo.ProductCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	dateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	idTable INT NOT NULL,
	discount INT DEFAULT 0,
	totalPrice FLOAT DEFAULT 0,
	status INT DEFAULT 0,  --0 chưa thanh toán, 1 đã thanh toán
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idProduct INT NOT NULL,
	count INT,
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idProduct) REFERENCES dbo.Product(id)
)
GO

CREATE TABLE Receipt
(
	id INT IDENTITY PRIMARY KEY,
	dateReceipt DATE NOT NULL DEFAULT GETDATE(),
	totalPrice FLOAT DEFAULT 0
)
GO

CREATE TABLE ReceiptInfo
(
	id INT IDENTITY PRIMARY KEY,
	idReceipt INT NOT NULL,
	idProduct INT NOT NULL,
	count INT DEFAULT 1,
	FOREIGN KEY (idReceipt) REFERENCES dbo.Receipt(id),
	FOREIGN KEY (idProduct) REFERENCES dbo.Product(id)
)
GO

CREATE TABLE Account
(
	userName NVARCHAR(100) PRIMARY KEY,
	passWord NVARCHAR(100),
	type INT DEFAULT 1 --1 admin | 0 staff
)
GO

--insert table food
DECLARE @i INT = 1
WHILE @i <= 10
BEGIN
	INSERT dbo.TableFood (name) VALUES  (N'Bàn '+ CAST(@i AS NVARCHAR(100)))
	SET @i = @i +1
END
GO

--insert product category
INSERT dbo.ProductCategory ( name ) VALUES  ( N'Cà Phê')
INSERT dbo.ProductCategory ( name ) VALUES  ( N'Nước giải khát đóng chai')
INSERT dbo.ProductCategory ( name ) VALUES  ( N'Bánh')
INSERT dbo.ProductCategory ( name ) VALUES  ( N'Trà')
INSERT dbo.ProductCategory ( name ) VALUES  ( N'Khác')

--insert product
INSERT dbo.Product ( name, price, inventory, idCategory ) VALUES  ( N'cà phê đen',20000.0, 23,  1)
INSERT dbo.Product ( name, price, inventory, idCategory ) VALUES  ( N'cà phê sữa',25000.0, 23,  1)
INSERT dbo.Product ( name, price, inventory, idCategory ) VALUES  ( N'Coca Cola',20000.0, 48,  2)
INSERT dbo.Product ( name, price, inventory, idCategory ) VALUES  ( N'Pepsi',20000.0, 72,  2)
INSERT dbo.Product ( name, price, inventory, idCategory ) VALUES  ( N'Nước Suối',35000.0, 96,  2)
INSERT dbo.Product ( name, price, inventory, idCategory ) VALUES  ( N'Bánh tiramusu',35000.0, 22,  3)
INSERT dbo.Product ( name, price, inventory, idCategory ) VALUES  ( N'Sandwich sữa chua',40000.0, 25,  3)
INSERT dbo.Product ( name, price, inventory, idCategory ) VALUES  ( N'Bánh Crepe',45000.0, 20,  3)
INSERT dbo.Product ( name, price, inventory, idCategory ) VALUES  ( N'Bánh cookies',25000.0, 60,  3)
INSERT dbo.Product ( name, price, inventory, idCategory ) VALUES  ( N'Bánh phô mai',40000.0, 20,  3)
INSERT dbo.Product ( name, price, inventory, idCategory ) VALUES  ( N'Trà xanh 0 độ',20000.0, 60,  4)
INSERT dbo.Product ( name, price, inventory, idCategory ) VALUES  ( N'Trà đào',35000.0, 90,  4)
INSERT dbo.Product ( name, price, inventory, idCategory ) VALUES  ( N'Trà ô long',30000.0, 72,  4)
INSERT dbo.Product ( name, price, inventory, idCategory ) VALUES  ( N'Trà đen Capuchino',35000.0, 60,  4)
INSERT dbo.Product ( name, price, inventory, idCategory ) VALUES  ( N'Bạc xỉu',25000.0, 50,  5)
INSERT dbo.Product ( name, price, inventory, idCategory ) VALUES  ( N'Kem ống',35000.0, 30,  5)
INSERT dbo.Product ( name, price, inventory, idCategory ) VALUES  ( N'Sữa chua',20000.0, 96,  5)
INSERT dbo.Product ( name, price, inventory, idCategory ) VALUES  ( N'Khoai tây chiên',15000.0, 120,  5)

--insert receipt
INSERT dbo.Receipt ( dateReceipt, totalPrice )  VALUES  ( GETDATE(),  650000.0 )

--insert receipt info
INSERT dbo.ReceiptInfo ( idReceipt, idProduct, count ) VALUES  ( 1, 5, 10 )
INSERT dbo.ReceiptInfo ( idReceipt, idProduct, count ) VALUES  ( 1, 11, 20 )

--insert account
INSERT dbo.Account ( userName, passWord, type ) VALUES  ( N'admin', N'1', 1)
INSERT dbo.Account ( userName, passWord, type ) VALUES  ( N'lamhan', N'1', 0)
INSERT dbo.Account ( userName, passWord, type ) VALUES  ( N'vinhlam', N'1', 0)

SELECT * FROM dbo.Account WHERE userName='lamhan' AND PASSWORD='1'
SELECT * FROM dbo.TableFood
SELECT * FROM Bill
INSERT dbo.Bill
        ( dateCheckIn ,
          idTable ,
          discount ,
          totalPrice ,
          status
        )
VALUES  ( GETDATE() , -- dateCheckIn - date
          3 , -- idTable - int
          0 , -- discount - int
          0.0 , -- totalPrice - float
          0  -- status - int
        )

SELECT * FROM dbo.TableFood
SELECT *  FROM bill 
SELECT * FROM dbo.BillInfo
delete FROM dbo.BillInfo WHERE id >=0
DELETE FROM dbo.Bill WHERE id >= 0
INSERT dbo.Bill
        ( 
          idTable 
        )
VALUES  (10)

UPDATE dbo.Bill SET dateCheckIn = N'2017-10-4' WHERE id = 46

UPDATE dbo.TableFood SET name = N'Bàn 5' WHERE id = 5
UPDATE dbo.TableFood SET status = N'Trống' WHERE id = 5
SELECT * FROM dbo.Bill
WHERE id 
SELECT * FROM dbo.TableFood
SELECT * FROM dbo.Account
UPDATE dbo.Account SET passWord = N'1962026656160185351301320480154111117132155'

SELECT * FROM dbo.Product WHERE CONVERT(VARBINARY(100), name) LIKE N'%' + CAST(CONVERT(VARBINARY(100),N'suối') AS NVARCHAR(100)) + N'%'
GO

CREATE PROC USP_GetListProductByName
@nameinput NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Product WHERE CONVERT(VARBINARY(100), name) LIKE N'%' + CAST(CONVERT(VARBINARY(100),@nameinput) AS NVARCHAR(100)) + N'%'
END
GO

EXEC USP_GetListProductByName @nameinput=N'sữa'
GO

CREATE PROC USP_DeleteProductCategory
