using System;
using System.Collections.Generic;
using System.Linq;

class OrderedBankingSystem
{
    static void Main()
    {
        string input = Console.ReadLine();
        var banks_accounts_balances = new Dictionary<string, Dictionary<string, decimal>>();

        while (input != "end")
        {
            var bank_account_balance = input.Split(' ').ToList();

            string bank = bank_account_balance[0];
            string account = bank_account_balance[2];

            decimal balance = decimal.Parse(bank_account_balance[4]);
            decimal previousBalance = 0;

            if (!banks_accounts_balances.ContainsKey(bank))
            {
                banks_accounts_balances[bank] = new Dictionary<string, decimal>();
            }

            var accountsAndBalances = banks_accounts_balances[bank];

            if (accountsAndBalances.ContainsKey(account))
            {
                previousBalance = accountsAndBalances[account];
            }
            banks_accounts_balances[bank][account] = balance + previousBalance;

            input = Console.ReadLine();
        }

        banks_accounts_balances = Order(banks_accounts_balances);
        PrintResult(banks_accounts_balances);
    }

    public static void PrintResult(Dictionary<string, Dictionary<string, decimal>> banks_accounts_balances)
    {
        foreach (var banks_accountAndBalances in banks_accounts_balances)
        {
            string bankName = banks_accountAndBalances.Key;
            var accountsAndBalances = banks_accountAndBalances.Value;

            foreach (var kvp in accountsAndBalances.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value} ({bankName})");
            }
        }
    }

    public static Dictionary<string, Dictionary<string, decimal>> Order(Dictionary<string, Dictionary<string, decimal>> banks_accounts_balances)
    {
        var ordered = banks_accounts_balances
        .OrderByDescending(bank => bank.Value.Sum(accountAndBalance => accountAndBalance.Value))
        .ThenByDescending(bank => bank.Value.Max(accountAndBalance => accountAndBalance.Value))
        .ToDictionary(x => x.Key, y => y.Value);

        return ordered;      
    }
}
