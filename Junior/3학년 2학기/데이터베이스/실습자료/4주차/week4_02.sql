USE master
GO

CREATE DATABASE deleteTest
GO

USE deleteTest
GO

CREATE TABLE memberTest(
	id INT IDENTITY(1,1),
	name VARCHAR(20)
)

INSERT memberTest VALUES('김나리')
INSERT memberTest VALUES('이백합')
INSERT memberTest VALUES('김장미')

DELETE FROM memberTest

CREATE DATABASE truncateTest
GO

USE truncateTest
GO

CREATE TABLE memberTest2(
	id INT IDENTITY(1,1),
	name VARCHAR(20)
)

INSERT memberTest2 VALUES('김나리')
INSERT memberTest2 VALUES('이백합')
INSERT memberTest2 VALUES('김장미')

TRUNCATE TABLE memberTest2

INSERT memberTest2 VALUES('김나리')
INSERT memberTest2 VALUES('이백합')
INSERT memberTest2 VALUES('김장미')