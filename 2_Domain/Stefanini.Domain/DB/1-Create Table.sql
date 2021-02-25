USE [IP_DEMO]

--drop table [dbo].[Trade]

IF (NOT EXISTS (SELECT * 
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_NAME = 'Trade'))
BEGIN
		CREATE TABLE [dbo].[Trade] (
			Trade_id INT PRIMARY KEY IDENTITY (1, 1),
			[Value] Decimal NOT NULL,
			ClientSector VARCHAR (50) NOT NULL,
			Categorie VARCHAR (50) NOT NULL,
			Created_at DATETIME
		);    
END
else
begin 
	print 'Table already Exists'
end