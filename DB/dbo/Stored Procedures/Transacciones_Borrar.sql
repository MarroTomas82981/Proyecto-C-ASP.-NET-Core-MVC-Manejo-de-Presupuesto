﻿-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Transacciones_Borrar
	@Id int


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DECLARE @Monto decimal(18,2);
	DECLARE @CuentaId int;
	DECLARE @TipoOperacionId int;


	SELECT @Monto = Monto,@CuentaId = CuentaId, @TipoOperacionId = cat.TipoOperacionId
	FROM Transacciones
	INNER JOIN Categorias cat
	ON cat.Id = Transacciones.CategoriaId
	WHERE  Transacciones.Id = @Id;

	DECLARE @FactorMultiplicatvo int = 1

	IF(@TipoOperacionId = 2)
		SET @FactorMultiplicatvo = -1;

	SET @Monto = @Monto * @FactorMultiplicatvo;

	UPDATE Cuentas
	SET Balance -= @Monto 
	WHERE Id = @CuentaId

	DELETE Transacciones
	WHERE Id = @Id;

END
