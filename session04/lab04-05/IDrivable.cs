using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04_05
{
    public interface IDrivable
    {
        void Start ();
        void Stop ();

        bool Started { get; }
    }

    public interface ISteerable
    {
        void TurnLeft();
        void TurnRight();
    }

    public interface IMovable : IDrivable, ISteerable {
        void Accelerate();
        void Break();
    }
}
