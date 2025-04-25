using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public class UserInfo{
    public int Id { get; set; }
    [Required(ErrorMessage ="Ad Alanı Boş Geçilemez!")]
    [StringLength(50, MinimumLength = 3)]
    public string? Name { get; set; }
    [Required(ErrorMessage ="Telefon Alanı Boş Geçilemez!")]
    [Phone]
    [StringLength(11, MinimumLength = 11)]
    public string? Phone { get; set; }
    [Required(ErrorMessage ="Email Alanı Boş Geçilemez!")]
    [EmailAddress]
    public string? Email { get; set; }
    [Required(ErrorMessage ="Katılım Alanı Boş Geçilemez!")]
    public bool? WillAttend { get; set; }
    }
}