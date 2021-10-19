using System;
using System.Collections.Generic;

namespace ProjectChocoMil
{
    public class Expenses
    {
        Dictionary<DateTime, Expense> expenses = new Dictionary<DateTime, Expense>();

        List<Expense> ExpensesList
        {
            get
            {
                List<Expense> expense = new List<Expense>();
                foreach (KeyValuePair<DateTime, Expense> entry in expenses)
                {
                    expense.Add(entry.Value);
                    Console.WriteLine($"Added {entry.Key} : {entry.Value}");
                }
                return expense;
            }
            set { }
        }
    }

    class Expense
    {
        enum ExpenseCategory
        {
            FoodAndDrink,
            Entertainment,
            Rent,
            Gas,
            Car,
            Travel,
            Utilities,
            Medical,
            Clothes,
            Pet
        }
    }
}
