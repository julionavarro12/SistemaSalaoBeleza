using System;
using System.ComponentModel.DataAnnotations;
using AngelaAraujo.Models;

namespace AngelaAraujo.Models
{
    public enum RoleUsuario
    {
        Admin = 0,
        Profissional = 1
    }

    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; } 

        public string Nome { get; set; } = string.Empty;  
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty; 

        public RoleUsuario Role { get; set; } = RoleUsuario.Profissional;
        public bool Ativo { get; set; } = true;

        public DateTime CriadoEm { get; set; } = DateTime.Now;
    }
}
