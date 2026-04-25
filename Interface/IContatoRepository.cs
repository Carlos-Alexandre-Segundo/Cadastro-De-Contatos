namespace projeto_mvc.Repository.Interface
{
    public interface IContatoRepository
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
