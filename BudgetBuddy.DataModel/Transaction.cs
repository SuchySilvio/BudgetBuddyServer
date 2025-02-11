using System;
using System.Collections.Generic;

namespace BudgetBuddy.DataModel;

public partial class Transaction
{
    public int Id { get; set; }

    public string Name { get; set; }

    public decimal Amount { get; set; }

    public DateTime Date { get; set; }

    public string Category { get; set; }

    public string Channel { get; set; }
}
