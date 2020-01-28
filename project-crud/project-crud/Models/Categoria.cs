namespace project_crud.Models
{
    public class Categoria
    {
        public long CategoriaId { get; set; }
        public string Nome { get; set; }

        public Categoria()
        {
        }

        public Categoria(long categoriaId, string nome)
        {
            CategoriaId = categoriaId;
            Nome = nome;
        }
    }
}