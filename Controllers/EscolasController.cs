using Microsoft.AspNetCore.Mvc;

using MinhasEscolas.Modelos;
using MinhasEscolas.Repositorios;


namespace MinhasEscolas.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EscolasController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Escola>> ObterTodas()
    {
        var escolas = EscolasRepositorio.ObterTodas();
        return escolas;
    }

    [HttpGet("{id}")]
    public ActionResult<Escola> Obter(int id) {
        var escola = EscolasRepositorio.Obter(id);
        if (escola == null)
            return NotFound();
        return escola;
    }

    [HttpPost]
    public IActionResult Criar(Escola escola) {
        EscolasRepositorio.Adicionar(escola);
        return CreatedAtAction(nameof(Obter), new {id = escola.Id}, escola);
    }

    [HttpPut()]
    public IActionResult Editar() {
        return Ok();
    }

    [HttpDelete()]
    public IActionResult Delete() {
        return Ok();
    }


    [HttpGet("{num}/{deno}")]
    public float Fracao(int num, int deno)
    {
        return (float)num / deno;
    }
}
