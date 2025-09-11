using System.ComponentModel.DataAnnotations;

namespace CrudNpN.Models;

public class Produto
{
    [Key]
    public int Id { get; set; }

    [Required, StringLength(120)]
    public string Nome { get; set; } = string.Empty;

    [Range(0, 999999999)]
    public decimal Preco { get; set; }

    [Range(0, int.MaxValue)]
    public int Estoque { get; set; }

    public ICollection<VendaProduto>? Vendas { get; set; }

}