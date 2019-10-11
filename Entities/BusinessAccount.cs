using System;
using System.Collections.Generic;
using System.Text;

namespace Metodosselado.Entities
{
    class BusinessAccount : Account                   //Conta Empresa.Foi colocado ":" Account para poder fazer herança
    {
        public double LoanLimit { get; set; }       //Limite para emprestimo(LoanLimit)

        public BusinessAccount()
        {

        }
        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)         //Aqui estou aproveitando o construtor da classe Account
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount) //Operação emprestimo
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }

    }
}
