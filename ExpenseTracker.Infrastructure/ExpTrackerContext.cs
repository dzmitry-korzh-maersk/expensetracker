using ExpenseTracker.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Infrastructure;

public class ExpTrackerContext : DbContext
{
    public ExpTrackerContext(DbContextOptions<ExpTrackerContext> options) : base(options)
    {
    }

    public DbSet<Expense> Expenses { get; set; } = null!;
    public DbSet<ExpenseCategory> ExpenseCategories { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<ExpenseCategory>().HasData(
        //    new ExpenseCategory { Id = 1, Name = "Groceries", Active = true },
        //    new ExpenseCategory { Id = 2, Name = "Eating Out", Active = true },
        //    new ExpenseCategory { Id = 3, Name = "Entertainment", Active = true },
        //    new ExpenseCategory { Id = 4, Name = "Bills", Active = true },
        //    new ExpenseCategory { Id = 5, Name = "Travel", Active = true },
        //    new ExpenseCategory { Id = 6, Name = "Other", Active = true }
        //);

        //modelBuilder.Entity<User>().HasData(
        //    new User { Id = 1, Name = "John Doe" }
        //);

        modelBuilder.Entity<Expense>()
            .Property(e => e.Amount)
            .HasColumnType("decimal(18,2)");
    }
}