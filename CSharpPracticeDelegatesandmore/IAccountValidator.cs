using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeDelegatesandmore
{
    internal interface IAccountValidator
    {
        event EventHandler<AccountArgs> Validated;
        void Validate(decimal balance);
    }
    public class SimpleValidator : IAccountValidator
    {
        private decimal _top;
        public SimpleValidator(decimal top)
        {
            _top = top;
        }
        public event EventHandler<AccountArgs> Validated = null!;

        public void Validate(decimal balance)
        {
            if (balance > _top)
            {
                Validated?.Invoke(this, new AccountArgs { Message = "Balance > top" });
            }
            else
            {
                Validated?.Invoke(this, new AccountArgs { Message = "Balance < top" });
            }
        }
    }
}
