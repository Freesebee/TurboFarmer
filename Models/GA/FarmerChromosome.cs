using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeneticSharp.Domain.Chromosomes;

namespace TurboFarmer.Models.GA
{
    public class FarmerChromosome : ChromosomeBase
    {
        public FarmerChromosome(int length) : base(length)
        {

        }

        public override IChromosome CreateNew()
        {
            throw new NotImplementedException();
        }

        public override Gene GenerateGene(int geneIndex)
        {
            throw new NotImplementedException();
        }
    }
}
