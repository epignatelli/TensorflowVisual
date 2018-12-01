using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] SplitV(this TFGraph graph, TensorFlow.TFOutput value, TensorFlow.TFOutput size_splits, TensorFlow.TFOutput split_dim, long num_split, string operName=null)
		{
			return graph.SplitV(value, size_splits, split_dim, num_split, operName);
		}
	}
}
