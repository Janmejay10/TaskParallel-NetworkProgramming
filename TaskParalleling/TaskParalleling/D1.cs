using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaaskParalleling
{
    public class Account
    {
        double _balance; int _id;
        public Account(int id, double balance)
        {
            this._id = id; this._balance = balance;
        }
        public int Id
        {
            get
            {
                return _id;
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
        Account _fromAccount; Account _toAccount;
        double _amountToTransfer;
        public AccountManager(Account fromAccount, Account toAccount,
                              double amountToTransfer)
        {
            this._fromAccount = fromAccount;
            this._toAccount = toAccount;
            this._amountToTransfer = amountToTransfer;
        }
        public void Transfer()
        {
            object _lock1, _lock2;

            if(_fromAccount.Id < _toAccount.Id)
            {
                _lock1 = _fromAccount;
                _lock2 = _toAccount;
            }
            else
            {
                _lock1 = _toAccount;
                _lock2 = _fromAccount;
            }
            Console.WriteLine(Thread.CurrentThread.Name + "is trying to acquire lock on" + ((Account)_lock1).Id.ToString());

            lock (_lock1)
            {
                Console.WriteLine(Thread.CurrentThread.Name + "acquired lock on" + ((Account)_lock1).Id.ToString());
                Console.WriteLine(Thread.CurrentThread.Name + "suspended for 1 second");
                Console.WriteLine(Thread.CurrentThread.Name + "back in action and trying to acquire lock on" + ((Account)_lock2).Id.ToString());

                Thread.Sleep(1000);
                lock (_lock2)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + "acquired lock on" + ((Account)_lock2).Id.ToString());
                    _fromAccount.Withdraw(_amountToTransfer);
                    _toAccount.Deposit(_amountToTransfer);
                    Console.WriteLine(Thread.CurrentThread.Name + "Transffered" + _amountToTransfer.ToString() + "from" + _fromAccount.Id.ToString() + "to" + _toAccount.Id.ToString());
                }
            }
        }
    }
}
