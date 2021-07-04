using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurboFarmer.Models.GameLogic
{
    public class Farm
    {
        private IList<Rabbit> _rabbits;
        private IList<Sheep> _sheeps;
        private IList<Pig> _pigs;
        private IList<Cow> _cows;
        private IList<Horse> _horses;
        private IList<SmallDog> _smallDogs;
        private IList<BigDog> _bigDogs;

        public Farm()
        {
            _rabbits = new List<Rabbit>();
            _sheeps = new List<Sheep>();
            _pigs = new List<Pig>();
            _cows = new List<Cow>();
            _horses = new List<Horse>();
            _smallDogs = new List<SmallDog>();
            _bigDogs = new List<BigDog>();
        }

        public void Breed(IList<DiceAnimal> diceAnimals)
        {
            foreach (DiceAnimal animal in diceAnimals)
            {
                int borned;
                switch(animal)
                {
                    case DiceAnimal.rabbit:
                        borned = _rabbits.Count + 1 / 2;
                        for (int i = 0; i < borned; i++)
                        {
                            _rabbits.Add(new Rabbit());
                        }
                        break;
                    case DiceAnimal.sheep:
                        borned = _sheeps.Count + 1 / 2;
                        for (int i = 0; i < borned; i++)
                        {
                            _sheeps.Add(new Sheep());
                        }
                        break;
                    case DiceAnimal.pig:
                        borned = _pigs.Count + 1 / 2;
                        for (int i = 0; i < borned; i++)
                        {
                            _pigs.Add(new Pig());
                        }
                        break;
                    case DiceAnimal.cow:
                        borned = _cows.Count + 1 / 2;
                        for (int i = 0; i < borned; i++)
                        {
                            _cows.Add(new Cow());
                        }
                        break;
                    case DiceAnimal.horse:
                        borned = _horses.Count + 1 / 2;
                        for (int i = 0; i < borned; i++)
                        {
                            _horses.Add(new Horse());
                        }
                        break;
                }
            }
        }

        public void Trade(IList<Animal> gives, IList<Animal> takes)
        {
            foreach (Animal animal in gives)
            {
                if(animal is Rabbit) _rabbits.RemoveAt(_rabbits.Count - 1);
                else if (animal is Sheep) _sheeps.RemoveAt(_sheeps.Count - 1);
                else if (animal is Pig) _pigs.RemoveAt(_pigs.Count - 1);
                else if (animal is Cow) _cows.RemoveAt(_cows.Count - 1);
                else if (animal is Horse) _horses.RemoveAt(_horses.Count - 1);
            }

            foreach (Animal animal in takes)
            {
                if (animal is Rabbit) _rabbits.Add(animal as Rabbit);
                else if (animal is Sheep) _sheeps.Add(animal as Sheep);
                else if (animal is Pig) _pigs.Add(animal as Pig);
                else if (animal is Cow) _cows.Add(animal as Cow);
                else if (animal is Horse) _horses.Add(animal as Horse);
            }
        }

        public void RemoveSmallDog()
        {
            if(_smallDogs.Count > 0) _smallDogs.RemoveAt(_smallDogs.Count-1);
        }

        public void RemoveBigDog()
        {
            if(_bigDogs.Count > 0) _bigDogs.RemoveAt(_bigDogs.Count - 1);
        }

        public void RemoveAll(Animal animal)
        {
            if (animal is Rabbit) _rabbits.Clear();
            else if (animal is Sheep) _sheeps.Clear();
            else if (animal is Pig) _pigs.Clear();
            else if (animal is Cow) _cows.Clear();
            else if (animal is Horse) _horses.Clear();
        }
    }
}
