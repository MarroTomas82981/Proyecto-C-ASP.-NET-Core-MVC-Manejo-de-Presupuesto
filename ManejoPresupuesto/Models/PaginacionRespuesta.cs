namespace ManejoPresupuesto.Models
{
    public class PaginacionRespuesta
    {
        public int Pagina { get; set; } = 1;
        public int RecordsPorPagina = 10;

        // 100 / 5 => 20
        public int CantidadTotalDePaginas => (int)Math.Ceiling((double)CantidadTotalRecords / RecordsPorPagina);
        public  int CantidadTotalRecords { get; set; }

        public string BaseURL { get; set; }

        public List<Categoria> Categorias { get; set; }

    }

    public class PaginacionRespuesta<T>: PaginacionRespuesta
    {
        public IEnumerable<T> Elementos { get; set; }

    }
}
