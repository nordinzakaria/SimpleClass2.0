using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TransactionList
{
    private const int TRANSACTION_SZ = 5;
    private Transaction[] dataset = new Transaction[TRANSACTION_SZ];
    private int numTrans = 0;

    public void Add(Transaction transaction)
    {
        dataset[numTrans++] = transaction;
    }

    public void Read(int num)
    {
        Console.WriteLine("Enter " + num + " transaction values:");

        for (int i = 0; i < num; i++)
        {
            Console.Write("Val: ");
            string val = Console.ReadLine();

            Transaction tr = new Transaction();
            tr.SetVal(int.Parse(val));

            Date date = new Date();
            Console.Write("Day: ");
            val = Console.ReadLine();
            date.SetDay(int.Parse(val));

            Console.Write("Month: ");
            val = Console.ReadLine();
            date.SetMonth(int.Parse(val));

            Console.Write("Year: ");
            val = Console.ReadLine();
            date.SetYear(int.Parse(val));

            tr.SetDate(date);

            Add(tr);
        }

    }

    public void Write()
    {
        Console.WriteLine("Transaction values:");
        for (int i = 0; i < numTrans; i++)
        {
            Console.WriteLine("Val: " + dataset[i].GetVal());
            Console.WriteLine("Day: " + dataset[i].GetDate().GetDay());
            Console.WriteLine("Month: " + dataset[i].GetDate().GetMonth());
            Console.WriteLine("Year: " + dataset[i].GetDate().GetYear());
        }
    }

}

