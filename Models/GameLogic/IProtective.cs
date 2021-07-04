using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurboFarmer.Models.GameLogic
{
    interface IProtective
    {
    }

    public class SmallDog : Animal, IProtective
    {

    }

    public class BigDog : Animal, IProtective
    {

    }
}
