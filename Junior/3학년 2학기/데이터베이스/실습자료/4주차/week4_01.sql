
USE master
GO
CREATE DATABASE testdb
GO

USE testdb
go

CREATE TABLE memberTest(
	id INT IDENTITY(1,1),
	name VARCHAR(20)
)

INSERT memberTest VALUES('±Ë≥™∏Æ')
INSERT memberTest VALUES('¿ÃπÈ«’')
INSERT memberTest VALUES('±Ë¿ÂπÃ')

SELECT * FROM memberTest;

CREATE TABLE products(
	pcode varchar(20) CONSTRAINT PK_pcode PRIMARY KEY,
	pname varchar(100) default '0',
	price varchar(10) default '0',
)

ALTER TABLE products
ADD pdate datetime NULL

ALTER TABLE products
ALTER COLUMN price VARCHAR(20)

ALTER TABLE products
DROP COLUMN pdate

SELECT * FROM memberTest

TRUNCATE TABLE memberTest

SELECT * FROM memberTest

DROP TABLE memberTest