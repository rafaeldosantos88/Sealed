using System;
using System.Collections.Generic;
using System.Text;

namespace Metodosselado.Entities
{
    class Account    //Classe conta
    {
        public int Number { get; set; }        // Numero Conta
        public string Holder { get; set; }    //Titular conta
        public double Balance { get; protected set; }  //Saldo da conta

        public Account()                    //Construtor padrão
        {

        }

        public Account(int number, string holder, double balance) //Construtor com argumentos
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public virtual void withdraw(double amount) //Operação Saque(WIthdraw) recebendo uma quantia(amount)
        {    //→Virtual(o metodo de saque(withdraw)pode ser sobreescrito ou sobreposto nas subclasses
            Balance -= amount + 5.0; //Para fazer o saque fazemos o Calculo Balance(saldo)- amount(quantia).Eu vou sacar a quantia mais o 5.0

        }
        public void Deposit(double amount) // Operação deposito
        {
            Balance += amount;

        }

    }
}
