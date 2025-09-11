using System.ComponentModel.DataAnnotations;


namespace CrudNpN.Models;

public class Venda
{
    [Key]
    public int Id { get; set; }
    public DateTime Data { get; set; } = DateTime.UtcNow;
    public int ClienteId { get; set; }
    public Cliente? Cliente { get; set; }
    public ICollection<VendaProduto> Itens { get; set; } = new List<VendaProduto>();
    public decimal Total => Itens?.Sum(i => i.PrecoUnitario * i.Quantidade) ?? 0m;

}