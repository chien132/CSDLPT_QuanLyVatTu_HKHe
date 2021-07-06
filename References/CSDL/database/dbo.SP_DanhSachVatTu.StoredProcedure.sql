USE [QLVT]
GO
/****** Object:  StoredProcedure [dbo].[SP_DanhSachVatTu]    Script Date: 12/23/2018 5:05:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DanhSachVatTu]
AS
BEGIN
SELECT MAVT, TENVT, DVT, SOLUONGTON FROM dbo.Vattu
ORDER BY TENVT
END
GO
