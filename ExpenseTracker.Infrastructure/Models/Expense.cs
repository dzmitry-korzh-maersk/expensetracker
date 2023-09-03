namespace ExpenseTracker.Infrastructure.Models;

public class Expense
{
    public int Id { get; set; }
    public string Description { get; set; } = null!;
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public int CategoryId { get; set; }
    public int UserId { get; set; }
    public ExpenseCategory Category { get; set; } = null!;
    public User User { get; set; } = null!;
}