using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RandomNormal(TFGraph graph, TensorFlow.TFShape shape, double mean=0, double stddev=1, int? seed=null, string operName=null)
		{
			return graph.RandomNormal(shape, mean, stddev, seed, operName);
		}
	}
}
