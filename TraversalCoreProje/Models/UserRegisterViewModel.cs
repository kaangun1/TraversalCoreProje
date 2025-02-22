using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models;

public class UserRegisterViewModel
{
    [Required(ErrorMessage = "Lütfen adınızı giriniz.")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "Lütfen soyadınızı giriniz.")]
    public string Surname { get; set; }
    
    [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz giriniz.")]
    public string UserName { get; set; }
    public string Username { get; internal set; }
    [Required(ErrorMessage = "Lütfen mail giriniz.")]
    public string Mail { get; set; }
    
    [Required(ErrorMessage = "Lütfen şifreyi giriniz.")]
    public string Password { get; set; }
    
    [Required(ErrorMessage = "Lütfen şifreyi tekrar girin giriniz.")]
    [Compare("Password",ErrorMessage = "Şifreler uyumlu değil!")]
    public string ConfirmPassword { get; set; }
}