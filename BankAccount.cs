﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MySupperBank
{
   public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }
        public BankAccount(string name,decimal initialBalance) {
            this.Owner = name;
            this.Balance = initialBalance;
        }
        public void MakeDeposite(decimal amount,DateTime date,string note) { 

        }
        public void MakeWithdrawel(decimal amount, DateTime date, string note)
        {

        }
    }
}
