using System.ComponentModel.DataAnnotations;

namespace CrudNpN.Models;

public class VendaProduto
{
    [Key]
    public int VendaId { get; set; }
    public Venda? Venda { get; set; }
    public int ProdutoId { get; set; }
    public Produto? Produto { get; set; }

    [Range(1, 999999)]
    public int Quantidade { get; set; }

    [Range(0, 999999999)]
    public decimal PrecoUnitario { get; set; } // captura o preço na data da venda

}