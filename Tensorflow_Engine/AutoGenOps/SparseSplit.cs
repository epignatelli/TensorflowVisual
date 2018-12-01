using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput[],TensorFlow.TFOutput[],TensorFlow.TFOutput[]> SparseSplit(this TFGraph graph, TensorFlow.TFOutput split_dim, TensorFlow.TFOutput indices, TensorFlow.TFOutput values, TensorFlow.TFOutput shape, long num_split, string operName=null)
		{
			return graph.SparseSplit(split_dim, indices, values, shape, num_split, operName);
		}
	}
}
