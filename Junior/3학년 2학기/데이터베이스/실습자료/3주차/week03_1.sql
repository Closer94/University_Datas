USE master
GO


--데이터베이스 만들기--

CREATE DATABASE TEST02
ON
PRIMARY			-- PRIMARY 그룹에 데이터 파일 생성
------------------------------
-- 데이터 파일 설정 --
------------------------------
( NAME = TEST02_DATA ,		--논리적 이름
	-- 경로 및 파일명 
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\test02.mdf' ,
	SIZE = 100MB ,
	MAXSIZE = 200 ,
	FILEGROWTH = 20%
)

------------------------------
-- 트랜잭션 로그 파일 설정--
------------------------------

LOG ON
( NAME = TEST02_LOG ,
  --경로 및 파일명
  FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\test02.ldf' ,
  SIZE = 20MB ,
  MAXSIZE = 50 ,
  FILEGROWTH = 10%
)

-- 데이터베이스 크기 늘리기 -- 

ALTER DATABASE TEST01
	MODIFY FILE
	( NAME = TEST01, 
	  SIZE = 400,
	  MAXSIZE = UNLIMITED,
	  FILEGROWTH = 10%
	)


-- 데이터베이스 크기 축소하기 --
ALTER DATABASE TEST01
SET
AUTO_SHRINK ON

-- 데이터베이스 삭제 --

DROP DATABASE TEST02