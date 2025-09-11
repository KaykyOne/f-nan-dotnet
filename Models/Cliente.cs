using System.ComponentModel.DataAnnotations;

namespace CrudNpN.Models;

public class Cliente
{
    [Key]
    public int Id { get; set; }

    [Required, StringLength(120)]
    public string Nome { get; set; } = string.Empty;

    [EmailAddress, StringLength(120)]
    public string? Email { get; set; }

    [StringLength(20)]
    public string? Telefone { get; set; }

    public ICollection<Venda>? Vendas { get; set; }

}