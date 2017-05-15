using System;
using System.Collections.Generic;
using System.Linq;

public class OptimizedBankingSystem
{
    public static void Main()
    {
        var banks_Accounts__Balances = new Dictionary<BankAccount, decimal>();

        string input = Console.ReadLine();

        while (input != "end")
        {
            string[] bank_accountName_balance = input
            .Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
            input = Console.ReadLine();

            decimal currentBalance = decimal.Parse(bank_accountName_balance[2]);
            BankAccount current_bank_accountName = ReadBankAndAccount(bank_accountName_balance);

            if (banks_Accounts__Balances.ContainsKey(current_bank_accountName))
            {
                banks_Accounts__Balances[current_bank_accountName] += currentBalance;
            }

            else
            {
                banks_Accounts__Balances[current_bank_accountName] = currentBalance;
            }
        }

        banks_Accounts__Balances = banks_Accounts__Balances
            .OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key.BankName.Length)
            .ToDictionary(y => y.Key, z => z.Value);

        foreach (var kvp in banks_Accounts__Balances)
        {
            Console.WriteLine($"{kvp.Key.AccountName} -> {kvp.Value} ({kvp.Key.BankName})");
        }
    }

    public static BankAccount ReadBankAndAccount(string[] bank_accountName_balance)
    {
        BankAccount current_bank_accountName_balance = new BankAccount
        {
            BankName = bank_accountName_balance[0],
            AccountName = bank_accountName_balance[1],
        };

        return current_bank_accountName_balance;
    }
}

