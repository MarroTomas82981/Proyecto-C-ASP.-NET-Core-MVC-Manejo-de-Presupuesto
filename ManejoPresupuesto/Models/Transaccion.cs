using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class Transaccion
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public decimal Monto { get; set; }
        [Display(Name = "Fecha Transaccion")]
        [DataType(DataType.Date)]

        public DateTime FechaTransaccion { get; set; } = DateTime.Today;
        [StringLength(maximumLength: 1000, ErrorMessage = "La nota no puede ser mayor a {1} caracteres")]

        public string Nota { get; set; }
        [Range(1, maximum: int.MaxValue, ErrorMessage = "Debe seleccionar una Cuenta")]
        [Display(Name = "Cuenta")]

        public int CuentaId { get; set; }
        [Range(1, maximum: int.MaxValue, ErrorMessage = "Debe seleccionar una categoria")]
        [Display(Name = "Categoria")]

        public int CategoriaId { get; set; }
        [Display(Name = "Tipo Operacion")]

        public TipoOperacion TipoOperacionId { get; set; } = TipoOperacion.Ingreso;

        public string Cuenta { get; set; }

        public string Categoria { get; set; }
    }

}

