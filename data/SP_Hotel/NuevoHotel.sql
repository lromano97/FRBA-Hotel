USE [GD1C2018]
GO
/****** Object:  StoredProcedure [dbo].[sp_AlmacenarHotel]    Script Date: 07/06/2018 6:17:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AlmacenarHotel] (@nombre_hotel nvarchar(255), @mail nvarchar(255), @estrellas numeric(18,0),
							@hote_telefono nvarchar(20), @calle nvarchar(255), @numero_calle numeric(18,0),
							@ciudad nvarchar(255), @pais nvarchar(255))
AS
BEGIN
	insert into CAIA_UNLIMITED.Direccion (dire_ciudad, dire_pais, dire_dom_calle, dire_nro_calle,
											dire_telefono)
	values (@ciudad, @pais, @calle, @numero_calle, @hote_telefono)
	insert into CAIA_UNLIMITED.Hotel (hote_nombre, hote_mail, hote_cant_estrellas, hote_habilitado, hote_fecha_creacion, dire_id)
	values (@nombre_hotel, @mail, @estrellas, 1, GETDATE(), (select dire_id from CAIA_UNLIMITED.Direccion
												where dire_telefono = @hote_telefono and
												dire_dom_calle = @calle and dire_ciudad = @ciudad
												and dire_pais = @pais and dire_nro_calle = @numero_calle))		
					
END