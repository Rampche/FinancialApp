using System.ComponentModel.DataAnnotations;
using Fina.Core.Enums;

namespace Fina.Core.Requests.Transactions;


public class CreateTransactionRequest : Request {
    [Required(ErrorMessage = "T�tulo inv�lido")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Tipo inv�lido")]
    public ETransactionType Type { get; set; } = ETransactionType.Withdraw;

    [Required(ErrorMessage = "Valor inv�lido")]
    public decimal Amount { get; set; }
    
    [Required(ErrorMessage = "Categoria inv�lida")]
    public long CategoryId { get; set; }

    [Required(ErrorMessage = "DAta inv�lida")]
    public DateTime? PaidOrReceivedAt { get; set; }
}
