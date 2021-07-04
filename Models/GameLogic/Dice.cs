using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurboFarmer.Models.GameLogic
{
    public enum DefaultDice
    {
        withWolf,
        withFox
    }

    public class Dice
    {
        private readonly Random _random;
        private readonly DiceAnimal[] _diceAnimals = null;
        private DiceAnimal _lastRolled;

        #region Constructors
        public Dice(DefaultDice dice)
        {
            _random = new Random();

            int i = 0;

            switch (dice)
            {
                case DefaultDice.withFox:

                    for (; i < 6; i++)
                    {
                        _diceAnimals[i] = DiceAnimal.rabbit;
                    }
                    _diceAnimals[i++] = DiceAnimal.sheep;
                    _diceAnimals[i++] = DiceAnimal.sheep;
                    _diceAnimals[i++] = DiceAnimal.pig;
                    _diceAnimals[i++] = DiceAnimal.pig;
                    _diceAnimals[i++] = DiceAnimal.horse;
                    _diceAnimals[i] = DiceAnimal.fox;

                    break;

                case DefaultDice.withWolf:

                    for (; i < 6; i++)
                    {
                        _diceAnimals[i] = DiceAnimal.rabbit;
                    }
                    _diceAnimals[i++] = DiceAnimal.sheep;
                    _diceAnimals[i++] = DiceAnimal.sheep;
                    _diceAnimals[i++] = DiceAnimal.sheep;
                    _diceAnimals[i++] = DiceAnimal.pig;
                    _diceAnimals[i++] = DiceAnimal.cow;
                    _diceAnimals[i] = DiceAnimal.wolf;

                    break;
            }
        }

        public Dice(DiceAnimal[] diceAnimals)
        {
            _random = new Random();
            _diceAnimals = diceAnimals;
        }

        public Dice(IList<DiceAnimal> diceAnimals)
        {
            _random = new Random();
            _diceAnimals = new DiceAnimal[diceAnimals.Count];

            int index = 0;

            foreach (DiceAnimal animal in diceAnimals)
            {
                _diceAnimals[index++] = animal; 
            }
        }
        #endregion

        public int SidesCount => _diceAnimals.Length;
        public DiceAnimal LastRolled => _lastRolled;
        public DiceAnimal Roll
        {
            get
            {
                _lastRolled = _diceAnimals[_random.Next(0, _diceAnimals.Length - 1)];
                return _lastRolled;
            }
        }

        public int AnimalCount(DiceAnimal diceAnimal)
        {
            int count = 0;
            
            foreach (DiceAnimal animal in _diceAnimals)
            {
                count = animal == diceAnimal ? ++count : count;
            }

            return count;
        }
        
        public double AnimalProbability(DiceAnimal diceAnimal)
        {
            int count = 0;
            foreach (DiceAnimal animal in _diceAnimals)
            {
                if (animal == diceAnimal) count++;
            }
            return count > 0 ? count / SidesCount : 0;
        }
    }
}
