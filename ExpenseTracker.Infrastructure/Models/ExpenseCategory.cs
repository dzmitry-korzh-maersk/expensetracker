﻿namespace ExpenseTracker.Infrastructure.Models;

public class ExpenseCategory
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public bool Active { get; set; }
}