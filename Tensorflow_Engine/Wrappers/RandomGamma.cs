using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RandomGamma(this TFGraph graph, TensorFlow.TFOutput shape, TensorFlow.TFOutput alpha, long? seed=null, long? seed2=null, string operName=null)
		{
			return graph.RandomGamma(shape, alpha, seed, seed2, operName);
		}
	}
}
