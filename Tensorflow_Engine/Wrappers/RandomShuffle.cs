using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RandomShuffle(this TFGraph graph, TensorFlow.TFOutput value, long? seed=null, long? seed2=null, string operName=null)
		{
			return graph.RandomShuffle(value, seed, seed2, operName);
		}
	}
}
