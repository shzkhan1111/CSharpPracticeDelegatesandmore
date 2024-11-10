using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeDelegatesandmore
{

    public class AccountArgs : EventArgs
    {
        public string? Message { get; set; }
    }
    public delegate void AccountHandler(object sender , AccountArgs args);


    public class BankAccount
    {
        public decimal Balance { get; private set; }

        /// <summary>
        /// Event Makes it such
        /// This will work but it will have a public += and -= and private invoke
        /// </summary>
        public event AccountHandler? Withdrawn = null;
        public event EventHandler<AccountArgs> WithDrawn2 = null!;
        
        /// <summary>
        /// This will work but it will have a public += and -= along with PUBLIC invoke 
        /// </summary>
        public  EventHandler<AccountArgs> WithDrawn3 = null!;

        private EventHandler<AccountArgs>? _withDrawn4 = null; 
        public event EventHandler<AccountArgs> WithDrawn4 { add { _withDrawn4 += value; } remove { _withDrawn4 -= value; } }



        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
            if (Balance < 0)
            {
                Withdrawn?.Invoke(this, new AccountArgs { Message = "WithDrawn 1 You are Over Drawn" });
                WithDrawn2?.Invoke(this, new AccountArgs { Message = "WithDrawn 2 You are Over Drawn" });
                _withDrawn4?.Invoke(this, new AccountArgs { Message = "WithDrawn 2 from private method You are Over Drawn" });
            }
        }
    }
}
