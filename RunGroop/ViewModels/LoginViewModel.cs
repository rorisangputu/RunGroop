using System;
using System.ComponentModel.DataAnnotations;
using CloudinaryDotNet.Actions;

namespace RunGroop.ViewModels;

public class LoginViewModel
{
    [Display(Name = "Email Address")]
    [Required(ErrorMessage = "Email Address is required")]
    public string EmailAddress { get; set; }
    [DataType(DataType.Password)]
    public string Password { get; set; }
}
