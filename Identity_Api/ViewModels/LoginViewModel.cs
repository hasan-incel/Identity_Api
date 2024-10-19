﻿using System.ComponentModel.DataAnnotations;

namespace Identity_Api.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        [EmailAddress]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
