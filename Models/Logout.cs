using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace app_back_.Models
{
    public class Logout
    {

        [MaxLength(20)]
        [EmailAddress]
        public string Email { get; set; }

    }
}