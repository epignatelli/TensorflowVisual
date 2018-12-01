using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RandomPoisson(this TFGraph graph, TensorFlow.TFOutput shape, TensorFlow.TFOutput rate, long? seed=null, long? seed2=null, string operName=null)
		{
			return graph.RandomPoisson(shape, rate, seed, seed2, operName);
		}
	}
}
