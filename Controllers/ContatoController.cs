using Microsoft.AspNetCore.Mvc;
using projeto_mvc.Repository.Interface;

namespace projeto_mvc.Controllers;

public class ContatoController : Controller
{
    private readonly IContatoRepository _contatoRepository;
    public ContatoController(IContatoRepository contatoRepository)
    {
        _contatoRepository = contatoRepository;
    }

    public IActionResult Index()
    {
        List<ContatoModel> contatos = _contatoRepository.BuscarTodos(); // chama o repositório
        return View(contatos);
    }
    
    public IActionResult Criar()
    {
     return View();   
    }
    public IActionResult Editar()
    {
     return View();   
    }
    public IActionResult ApagarConfirmacao()
    {
     return View();   
    }


    [HttpPost]
    public IActionResult Criar(ContatoModel contato)
    {
        _contatoRepository.Adicionar(contato);
        return RedirectToAction("Index");
    }
}
