using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AngelaAraujo.Models;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace AngelaAraujo.Service
{
public class ClienteService : IClienteService
{
    
private readonly ApplicationContext _context;

public ClienteService (ApplicationContext context)
{

_context = context;


}

public IEnumerable <Cliente> ObterTodos()
{
 return _context.Clientes.ToList();

}

public async Task <Cliente> ObterPorId(int id)
    {
        var cliente = await _context.Clientes.FindAsync (id);
        if (cliente == null)
        {
            throw new Exception("Cliente não encontrado");
            return cliente;
        }        
        
    } 


public async Task<Cliente> Criar(Cliente cliente)
{
    if (string.IsNullOrWhiteSpace(cliente.Nome))
    {
        throw new Exception("Nome é obrigatório");
    }

    var novoCliente = new Cliente
    {
        Nome = cliente.Nome,
        Telefone = cliente.Telefone
    };

    _context.Clientes.Add(novoCliente);
    await _context.SaveChangesAsync();

    return novoCliente;
    
    }

 public async Task<Cliente> Atualizar(int id, Cliente clienteAtualizado)
    {
        var cliente = await _context.Clientes.FindAsync(id);
        if (cliente == null) throw new Exception("Cliente não encontrado");

        cliente.Nome = clienteAtualizado.Nome;
        cliente.Telefone = clienteAtualizado.Telefone;

        await _context.SaveChangesAsync();
        return cliente;
    }
 public async  Task <Cliente>Deletar (int id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente == null)
            throw new Exception ("Cliente não encontrado");

            _context.cliente.Remove(Cliente);
            await _context.SaveChangesAsync();

        }


}
}