using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4_Lab_6
{
    internal interface MultipleInterface
    {
        public interface IDriveable
        {
            void Start();
            void Stop();
            bool Started { get; }
        }

        public interface ISteerable
        {
            void TurnLeft();
            void TurnRight();
        }

        public interface IMovable : IDriveable, ISteerable
        {
            void Accelerate();
            void Brake();
        }


    }
}
