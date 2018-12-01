using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RandomNormal(this TFGraph graph, TensorFlow.TFShape shape, double mean=0, double stddev=1, int? seed=null, string operName=null)
		{
			return graph.RandomNormal(shape, mean, stddev, seed, operName);
		}
	}
}
