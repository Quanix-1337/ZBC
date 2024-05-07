using System;
using System.Collections.Generic;

namespace ZBC.Models;

public partial class Article
{
    public int ArticleId { get; set; }

    public string? Bookname { get; set; }

    public string? Author { get; set; }

    public string? Publisher { get; set; }

    public DateTime Date { get; set; }
    public string? Price { get; set; }

    public string? Purchased { get; set; }

    public string? BorrowID { get; set; }

    public string? UserID { get; set; }

    public string? MaterialID { get; set; }

    public DateTime BorrowDate { get; set; }

public DateTime ReturnDate { get; set; }
public string? ArticleSummary { get; set; }
}
