DROP DATABASE IF EXISTS IMDB;
GO
CREATE DATABASE IMDB
GO
USE IMDB
GO
CREATE TABLE Movies(
	Id INT IDENTITY PRIMARY KEY,
	Title NVARCHAR(60) NOT NULL,
	Year INT NOT NULL,
	Rating DECIMAL(3,1) NOT NULL 
)

INSERT INTO Movies(Title,Year,Rating) VALUES
(N'Fight Club',1999, 8.8),
(N'The Lord of the Rings: The Fellowship of the Ring',200, 8.8),
(N'Intersteller',2014, 8.6),
(N'The Prestige',2006, 8.5),
(N'The Curious Case of Benjamin Button', 2008, 7.8),
(N'Eternal Sunshine of the Spotless Mind',2004, 8.3),
(N'Titanic',1997, 7.8),
(N'The Pianist', 2002, 8.5);
            