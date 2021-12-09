USE master;
GO;

CREATE DATABASE YapilacaklarDB COLLATE TURKISH_CI_AS;
GO

USE YapilacaklarDB;
GO;
CREATE TABLE Yapilacaklar(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Gorev NVARCHAR(50) NOT NULL,
	YapildiMi BIT NOT NULL DEFAULT(0)

)

INSERT INTO Yapilacaklar(Gorev,YapildiMi) VALUES
(N'Ders Çalış',1) ,(N'Kitap Oku',0),
(N'Alışveriş Yap',0), (N'Ezgi''nin ıslak keki yeme',1)
