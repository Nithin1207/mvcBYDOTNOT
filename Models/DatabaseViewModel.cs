using System;
using System.ComponentModel.DataAnnotations; // 🔸 Required for [Required]

namespace sellyourcar.Models;

public class DatabaseViewModel
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;

    [Required]
    public string Content { get; set; } = string.Empty;

    [Required]
    public DateTime Created { get; set; } = DateTime.Now;
}
