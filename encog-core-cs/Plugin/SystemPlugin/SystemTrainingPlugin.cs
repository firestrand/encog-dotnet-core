using System;
using Encog.Engine.Network.Activation;
using Encog.ML;
using Encog.ML.Data;
using Encog.ML.Factory;
using Encog.ML.Factory.Train;
using Encog.ML.Train;

namespace Encog.Plugin.SystemPlugin
{
    /// <summary>
    /// Create the system training methods.
    /// </summary>
    public class SystemTrainingPlugin : IEncogPluginService1
    {
        /// <summary>
        /// The factory for simulated annealing.
        /// </summary>
        private readonly AnnealFactory _annealFactory = new AnnealFactory();

        /// <summary>
        /// The factory for backprop.
        /// </summary>
        private readonly BackPropFactory _backpropFactory = new BackPropFactory();

        /// <summary>
        /// The factory for genetic.
        /// </summary>
        private readonly GeneticFactory _geneticFactory = new GeneticFactory();

        /// <summary>
        /// The factory for LMA.
        /// </summary>
        private readonly LMAFactory _lmaFactory = new LMAFactory();

        /// <summary>
        /// The factory for Manhattan networks.
        /// </summary>
        private readonly ManhattanFactory _manhattanFactory = new ManhattanFactory();

        /// <summary>
        /// The factory for neighborhood SOM.
        /// </summary>
        private readonly NeighborhoodSOMFactory _neighborhoodFactory
            = new NeighborhoodSOMFactory();

        /// <summary>
        /// Factory for PNN.
        /// </summary>
        private readonly PNNTrainFactory _pnnFactory = new PNNTrainFactory();

        /// <summary>
        /// Factory for quick prop.
        /// </summary>
        private readonly QuickPropFactory _qpropFactory = new QuickPropFactory();

        /// <summary>
        /// The factory for RPROP.
        /// </summary>
        private readonly RPROPFactory _rpropFactory = new RPROPFactory();

        /// <summary>
        /// The factory for SCG.
        /// </summary>
        private readonly SCGFactory _scgFactory = new SCGFactory();

        /// <summary>
        /// The factory for SOM cluster.
        /// </summary>
        private readonly ClusterSOMFactory _somClusterFactory = new ClusterSOMFactory();

        /// <summary>
        /// Factory for SVD.
        /// </summary>
        private readonly RBFSVDFactory _svdFactory = new RBFSVDFactory();

        /// <summary>
        /// The factory for basic SVM.
        /// </summary>
        private readonly SVMFactory _svmFactory = new SVMFactory();

        /// <summary>
        /// The factory for SVM-Search.
        /// </summary>
        private readonly SVMSearchFactory _svmSearchFactory = new SVMSearchFactory();

        #region IEncogPluginService1 Members

        /// <inheritdoc/>
        public String PluginDescription
        {
            get
            {
                return "This plugin provides the built in training " +
                       "methods for Encog.";
            }
        }

        /// <inheritdoc/>
        public String PluginName
        {
            get { return "HRI-System-Training"; }
        }

        /// <summary>
        /// This is a type-1 plugin.
        /// </summary>
        public int PluginType
        {
            get { return 1; }
        }


        /// <summary>
        /// This plugin does not support activation functions, so it will 
        /// always return null. 
        /// </summary>
        /// <param name="name">Not used.</param>
        /// <returns>The activation function.</returns>
        public IActivationFunction CreateActivationFunction(String name)
        {
            return null;
        }

        public IMLMethod CreateMethod(String methodType, String architecture,
                                      int input, int output)
        {
            // TODO Auto-generated method stub
            return null;
        }

        public IMLTrain CreateTraining(IMLMethod method, IMLDataSet training,
                                       String type, String args)
        {
            String args2 = args ?? "";

            if (String.Compare(MLTrainFactory.TypeRPROP, type) == 0)
            {
                return _rpropFactory.Create(method, training, args2);
            }
            if (String.Compare(MLTrainFactory.TypeBackprop, type) == 0)
            {
                return _backpropFactory.Create(method, training, args2);
            }
            if (String.Compare(MLTrainFactory.TypeSCG, type) == 0)
            {
                return _scgFactory.Create(method, training, args2);
            }
            if (String.Compare(MLTrainFactory.TypeLma, type) == 0)
            {
                return _lmaFactory.Create(method, training, args2);
            }
            if (String.Compare(MLTrainFactory.TypeSVM, type) == 0)
            {
                return _svmFactory.Create(method, training, args2);
            }
            if (String.Compare(MLTrainFactory.TypeSVMSearch, type) == 0)
            {
                return _svmSearchFactory.Create(method, training, args2);
            }
            if (String.Compare(MLTrainFactory.TypeSOMNeighborhood, type) == 0)
            {
                return _neighborhoodFactory.Create(method, training, args2);
            }
            if (String.Compare(MLTrainFactory.TypeAnneal, type) == 0)
            {
                return _annealFactory.Create(method, training, args2);
            }
            if (String.Compare(MLTrainFactory.TypeGenetic, type) == 0)
            {
                return _geneticFactory.Create(method, training, args2);
            }
            if (String.Compare(MLTrainFactory.TypeSOMCluster, type) == 0)
            {
                return _somClusterFactory.Create(method, training, args2);
            }
            if (String.Compare(MLTrainFactory.TypeManhattan, type) == 0)
            {
                return _manhattanFactory.Create(method, training, args2);
            }
            if (String.Compare(MLTrainFactory.TypeSvd, type) == 0)
            {
                return _svdFactory.Create(method, training, args2);
            }
            if (String.Compare(MLTrainFactory.TypePNN, type) == 0)
            {
                return _pnnFactory.Create(method, training, args2);
            }
            if (String.Compare(MLTrainFactory.TypeQPROP, type) == 0)
            {
                return _qpropFactory.Create(method, training, args2);
            }
            throw new EncogError("Unknown training type: " + type);
        }

        /// <inheritdoc/>
        public int PluginServiceType
        {
            get { return EncogPluginBaseConst.SERVICE_TYPE_GENERAL; }
        }

        #endregion
    }
}