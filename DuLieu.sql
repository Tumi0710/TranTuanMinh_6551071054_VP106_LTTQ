CREATE DATABASE DuLieu;
GO

USE DuLieu
GO

CREATE TABLE SanPham (
	MaSanPham NVARCHAR(10) NOT NULL PRIMARY KEY,
	TenSanPham NTEXT NOT NULL,
	GiaBan NVARCHAR(12) NOT NULL
);
GO

INSERT INTO SanPham (MaSanPham, TenSanPham, GiaBan) VALUES
(N'SP001', N'Nước khoáng', N'10000'),
(N'SP002', N'Sữa tươi Vinamilk', N'25000'),
(N'SP003', N'Gạo tẻ thơm', N'45000'),
(N'SP004', N'Bánh quy AFC', N'30000'),
(N'SP005', N'Dầu ăn Tường An', N'65000');
GO