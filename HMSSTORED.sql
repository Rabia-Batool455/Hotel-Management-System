-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
USE HMS2;
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================



Create PROCEDURE Servicessinsert
    @ServiceID INT,
    @ServiceName NVARCHAR(50),
    @Description NVARCHAR(50),
    @Price decimal(10,2)
    
AS
BEGIN
    INSERT INTO Servicess (ServiceID, ServiceName,Description, Price)
    VALUES (@ServiceID, @ServiceName, @Description, @Price);
END
exec Servicessinsert 6,'break','hello',20.00

