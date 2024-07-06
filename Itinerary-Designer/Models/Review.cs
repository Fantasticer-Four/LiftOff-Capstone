using System;
using System.ComponentModel.DataAnnotations;

namespace Reviews.Models;

public class Review
{
    public int Id { get; set; }
    private int nextId { get; set; } = 1;
    public string Title { get; set; }
    [Required]
    public string Author { get; set; }
    [Required]
    public string Content { get; set; }
    [Display(Name = "Posted Date")]
    public DateTime PostedDate { get; set; }
    
    public Review()
    {
        Id = nextId;
        nextId++;
        PostedDate = DateTime.UtcNow;
    }
    public Review(string title, string author, string content)
    {
        Title = title;
        Author = author;
        Content = content;
    }
    
}
