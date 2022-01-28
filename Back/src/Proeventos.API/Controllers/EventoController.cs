using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proeventos.API.Models;

namespace Proeventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
            EventoId = 1,
            Tema = "Angular 11 e .Net 5",
            Local = "São Paulo",    
            Lote = "1º lote",
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            QtdPessoas = 250,
            ImageURL = "http://www.google.com.br"}, 

            new Evento(){
            EventoId = 2,
            Tema = "Angular 11 e .Net 5",
            Local = "São Paulo",
            Lote = "2º lote",
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            QtdPessoas = 350,
            ImageURL = "http://www.google.com.br"},
            
            new Evento(){
            EventoId = 3,
            Tema = "Angular 11 e .Net 5",
            Local = "São Paulo",
            Lote = "3º lote",
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            QtdPessoas = 450,
            ImageURL = "http://www.google.com.br"}
        };
        
        public EventoController(ILogger<EventoController> logger)
        {
        
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }
        
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(x => x.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete()]
        public string Delete()
        {
            return "Exemplo de Delete";
        }
    
        [HttpDelete("{id}")]
        public string DeleteId(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}
