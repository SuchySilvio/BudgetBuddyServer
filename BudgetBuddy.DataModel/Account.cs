using System;
using System.Collections.Generic;

namespace BudgetBuddy.DataModel;

public partial class Account
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string AccountId { get; set; }

    public decimal Balance { get; set; }
}
