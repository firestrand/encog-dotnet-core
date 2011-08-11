using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Encog.ML;
using Encog.ML.Train;
using Encog.MathUtil.Randomize;
using Encog.Util.Concurrency;
using Encog.Util.Logging;

namespace Encog.Neural.Networks.Training.PSO
{
    /// <summary>
    /// Allows a network to be trained using the particle swarm optimization algorithm
    /// </summary>
    public class ParticleSwarmOptimizationAlgorithm : BasicTraining, IMultiThreadable
    {
        /// <summary>
        /// Basic constructor
        /// </summary>
        /// <param name="network"></param>
        /// <param name="randomizer"></param>
        /// <param name="calculateScore"></param>
        public ParticleSwarmOptimizationAlgorithm(BasicNetwork network,IRandomizer randomizer, ICalculateScore calculateScore)
            : base(TrainingImplementationType.Iterative)
        {
        }

        public override bool CanContinue
        {
            get { throw new NotImplementedException(); }
        }

        public override ML.IMLMethod Method
        {
            get { throw new NotImplementedException(); }
        }

        public override void Iteration()
        {
            EncogLogging.Log(EncogLogging.LevelInfo,
                             "Performing PSO iteration.");
            PreIteration();
            //Genetic.Iteration();
            //Error = Genetic.Error;
            PostIteration();
        }

        public override Propagation.TrainingContinuation Pause()
        {
            throw new NotImplementedException();
        }

        public override void Resume(Propagation.TrainingContinuation state)
        {
            throw new NotImplementedException();
        }

        public int ThreadCount
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
