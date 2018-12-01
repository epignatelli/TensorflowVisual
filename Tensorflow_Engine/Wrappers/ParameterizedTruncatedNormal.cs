using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ParameterizedTruncatedNormal(this TFGraph graph, TensorFlow.TFOutput shape, TensorFlow.TFOutput means, TensorFlow.TFOutput stdevs, TensorFlow.TFOutput minvals, TensorFlow.TFOutput maxvals, long? seed=null, long? seed2=null, string operName=null)
		{
			return graph.ParameterizedTruncatedNormal(shape, means, stdevs, minvals, maxvals, seed, seed2, operName);
		}
	}
}
