CREATE PROCEDURE [dbo].[CreateTrade]
AS
		Declare @Value Decimal 
		Declare @ClientSector varchar(50)
BEGIN
	BEGIN TRY
		If(@Value < 1000000 AND @ClientSector ='Public')
				begin
							INSERT INTO [dbo].[Trade]
									   ([Value]
									   ,[ClientSector]
									   ,[Categorie]
									   ,[Created_at])
								 VALUES
									   (@Value
									   ,@ClientSector
									   ,'LOWRISK'
									   ,GETDATE())
					SELECT 'LOWRISK' as output
				end
		If(@Value > 1000000 AND @ClientSector ='Public')
				begin
							INSERT INTO [dbo].[Trade]
									   ([Value]
									   ,[ClientSector]
									   ,[Categorie]
									   ,[Created_at])
								 VALUES
									   (@Value
									   ,@ClientSector
									   ,'SectorMEDIUMRISK'
									   ,GETDATE())
					SELECT 'SectorMEDIUMRISK' as output
				end

		If(@Value > 1000000 AND @ClientSector ='Private')
				begin
							INSERT INTO [dbo].[Trade]
									   ([Value]
									   ,[ClientSector]
									   ,[Categorie]
									   ,[Created_at])
								 VALUES
									   (@Value
									   ,@ClientSector
									   ,'SectorHIGHRISK'
									   ,GETDATE())
					SELECT 'SectorHIGHRISK'  as output
				end

END TRY
BEGIN CATCH
		  SELECT
			ERROR_MESSAGE() AS MensagemdeErro,
			ERROR_NUMBER() AS NúmeroErrado
END CATCH
END
GO
