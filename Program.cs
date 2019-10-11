using Metodosselado.Entities;
using System;

namespace Metodosselado
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Rafael", 500.0);
            Account acc2 = new SavingsAccount(1002, "Divinha", 500, 0.01); //Aqui usamos o upcasting da classe Account para subsclasse SavingsAccount

            //Agora vou fazer um saque nas duas contas
            acc1.withdraw(10);
            acc2.withdraw(10);

            //agora vou imprimir o saldo

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

        }
    }
}
