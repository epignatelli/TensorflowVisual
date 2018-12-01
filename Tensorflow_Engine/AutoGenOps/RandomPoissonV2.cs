using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RandomPoissonV2(this TFGraph graph, TensorFlow.TFOutput shape, TensorFlow.TFOutput rate, long? seed=null, long? seed2=null, TensorFlow.TFDataType? dtype=null, string operName=null)
		{
			return graph.RandomPoissonV2(shape, rate, seed, seed2, dtype, operName);
		}
	}
}
