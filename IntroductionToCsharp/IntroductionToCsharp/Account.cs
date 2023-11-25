using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public class Account
    {
        double _balance;
        int _id;

        public Account(int id, double account)
        {
            this._id = id;
            this._balance = account;
        }

        public int ID
        {
            get
            {
                return this._id;
            }
        }
        public void Withdraw(double amount)
        {
            _balance -= amount;
        }
        public void Deposit(double amount)
        {
            _balance += amount;
        }

    }

    public class AccountManager
    {
        Account _fromaccount; Account _toaccount; double _amounttotransfer;

        public AccountManager(Account fromAccount, Account toAccount, double amountToTransfer)
        {
            this._fromaccount = fromAccount;
            this._toaccount = toAccount;
            this._amounttotransfer = amountToTransfer;
        }

        public void Transfer()
        {
            //This code created Deadlock

            //Console.WriteLine(Thread.CurrentThread.Name + "Trying to acquire lock on" + _fromaccount.ID.ToString());
            //lock (_fromaccount)
            //{
            //    Console.WriteLine(Thread.CurrentThread.Name + "Acquired lock on" + _fromaccount.ID.ToString());
            //    Console.WriteLine(Thread.CurrentThread.Name + "Suspended for 1 second" + _fromaccount.ID.ToString());
            //    Thread.Sleep(1000);
            //    Console.WriteLine(Thread.CurrentThread.Name + "Back in action and trying to acquire lock on " + _fromaccount.ID.ToString());
            //    lock (_toaccount)
            //    {
            //        _fromaccount.Withdraw(_amounttotransfer);
            //        _toaccount.Deposit(_amounttotransfer);
            //    }
            //}

            //How to resolve deadlock

            //object _lock1, _lock2;
            //if(_fromaccount.ID < _toaccount.ID)
            //{
            //    _lock1 = _fromaccount;
            //    _lock2 = _toaccount;
            //}
            //else
            //{
            //    _lock1 = _toaccount;
            //    _lock2 = _fromaccount;
            //}
            //Console.WriteLine(Thread.CurrentThread.Name + "Trying to acquire lock on" + ((Account)_lock1).ID.ToString());
            //lock (_lock1)
            //{
            //    Console.WriteLine(Thread.CurrentThread.Name + "Acquired lock on" + ((Account)_lock1).ID.ToString());
            //    Console.WriteLine(Thread.CurrentThread.Name + "Suspended for 1 second" + ((Account)_lock1).ID.ToString());
            //    Thread.Sleep(1000);
            //    Console.WriteLine(Thread.CurrentThread.Name + "Back in action and trying to acquire lock on " + ((Account)_lock1).ID.ToString());
            //    lock (_lock2)
            //    {
            //        Console.WriteLine(Thread.CurrentThread.Name + "Trying to acquire lock on" + ((Account)_lock2).ID.ToString());
            //        _fromaccount.Withdraw(_amounttotransfer);
            //        _toaccount.Deposit(_amounttotransfer);
            //    }
            //}
        }
    }
}
