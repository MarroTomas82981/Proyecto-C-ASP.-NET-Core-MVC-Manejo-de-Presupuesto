-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE TiposCuentas_Insertar
	-- Add the parameters for the stored procedure here
	 @Nombre nvarchar(50),
	 @UsuarioId int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DECLARE @Orden int;
	SELECT @Orden = COALESCE(MAX(Orden),0)+1
	FROM TipoCuentas
	WHERE UsuarioId = @UsuarioId

	INSERT INTO TipoCuentas(Nombre,UsuarioId,Orden)
	VALUES(@Nombre,@UsuarioId,@Orden);

	SELECT SCOPE_IDENTITY();

END
