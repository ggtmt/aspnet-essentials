
using Microsoft.AspNetCore.Mvc;

namespace GerenciaTarefa.Controllers;

public class TarefaController:Controller{

     //view=site
public IActionResult Index(){
   
   ViewData["Cabecalho"] = "Tarefa Diaria";
   ViewData["Titulo"] ="Planejar Aula Senai";
   ViewData["Descricao"] ="Criar nova PEUC";
    return View();
}

}