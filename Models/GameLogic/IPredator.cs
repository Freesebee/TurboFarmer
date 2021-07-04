using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurboFarmer.Models.GameLogic
{
    interface IPredator
    {
    }

    public class Fox : Animal, IPredator
    {

    }

    public class Wolf : Animal, IPredator
    {

    }
}
