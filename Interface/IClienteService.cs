using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AngelaAraujo.Models;
using System.Collections.Generic;
using AngelaAraujo.Service;
using AngelaAraujo;


public interface IClienteService
{
    
    Task<Cliente> ObterPorId(int id);
    Task<Cliente> Criar(Cliente cliente);
    Task<Cliente> Atualizar(int id, Cliente cliente);
    Task<Cliente> Deletar(int id);
}