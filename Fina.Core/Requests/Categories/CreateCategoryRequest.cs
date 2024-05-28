namespace Fina.Core.Requests.Categories;

// Flunt <- 
//FluentValidation
public class GetCategoryRequest : Request
{
    [Required(ErrorMessage = "T�tulo inv�lido")]
    [MaxLenght(80, ErrorMessage = "O t�tulo deve conter at� 80 caracteres")]
    public string Title { get; set; } = string.Empty;


    [Required(ErrorMessage = "Descri��o inv�lida")]
    public string Description? { get; set; } = string.Empty;
}