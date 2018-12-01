using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] Split(this TFGraph graph, TensorFlow.TFOutput split_dim, TensorFlow.TFOutput value, long num_split, string operName=null)
		{
			return graph.Split(split_dim, value, num_split, operName);
		}
	}
}
