﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class EventoController : ControllerBase
  {
    
    private readonly DataContext _context;
    public EventoController(DataContext context)
    {
      _context = context;

    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
      return _context.Eventos;
    }
    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
      yield return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
    }
    [HttpPost]
    public string Post()
    {
      return "Post Example";
    }
    [HttpPut("{id}")]
    public string Put(int id)
    {
      return $"Put Example with id = {id}";
    }
    [HttpDelete("{id}")]
    public string Delete(int id)
    {
      return $"Delete Example with id = {id}";
    }
  }
}
