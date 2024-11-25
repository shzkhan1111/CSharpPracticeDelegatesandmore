using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeDelegatesandmore
{
    public abstract class MiddlewarePipe
    {
        protected Action<string> _action;
        public MiddlewarePipe(Action<string> action)
        {
            this._action = action;   
        }
        public abstract void Handle(string msg);
    }


    public class WrapPipe : MiddlewarePipe
    {

        public WrapPipe(Action<string> action) : base(action){}
        public override void Handle(string msg)
        {
            Console.WriteLine("Perfroming a task before displaying a message");
            _action(msg);
            Console.WriteLine("Perfroming a task before displaying a message");
        }
    }
    public class TryPipe : MiddlewarePipe
    {

        public TryPipe(Action<string> action) : base(action) { }
        public override void Handle(string msg)
        {
            Console.WriteLine("Perfroming Try");
            _action(msg);
            Console.WriteLine("Perfroming Try");
            Console.WriteLine("Catching Try");
        }
    }

    public class PipeBuilder
    {
        Action<string> _mainaction;
        public PipeBuilder(Action<string> action)
        {
            _mainaction = action;
        }

        public void AddPipe(Type pipeType)
        {
            if (!pipeType.GetTypeInfo().IsInstanceOfType(typeof(MiddlewarePipe)))
            {
                throw new Exception();
            }
        }
    }
}
