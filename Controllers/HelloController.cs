using Microsoft.AspNetCore.Mvc;


namespace HelloWord.Controllers
{
    [Route("~/")] // estou dizendo que essa classe controladora vai trabalhar na raiz do servidor
    [ApiController] // é uma classe que vai mostrar o caminho 
    public class HelloController
    {
        [HttpGet] // metodo que vai devolver o texto que no caso é o hello word
        public string Hello() // metodo de texto
        {
            return " Hello Word! Turma .NET 03 ";
        }
        [HttpGet ("/bsmgenerationbrasil")] // o modo de usar o mesmo endereço ip httpget("/") conhecido com endpoints , para quebrar linha <br >
        public string Bsm() 
        {
            return "Persistencia\nResponsabilidade Pessoal\nMentalidade de Crescimento\nOrientação ao Futuro\nComunicação\nOrientação aos Detalhes\nProatividade\nTrabalho em Equipe";
        }
        [HttpGet("/objetivosdeaprendizagem")] // o modo de usar o mesmo endereço ip httpget("/") conhecido com endpoints , para quebrar linha <br >
        public string Objetivos()
        {
            return "Meu objetivo é absorver o maximo possivel de AspNet";
        }
    }
}

       
    
