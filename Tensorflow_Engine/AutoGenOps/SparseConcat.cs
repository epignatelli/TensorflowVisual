using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> SparseConcat(this TFGraph graph, TensorFlow.TFOutput[] indices, TensorFlow.TFOutput[] values, TensorFlow.TFOutput[] shapes, long concat_dim, string operName=null)
		{
			return graph.SparseConcat(indices, values, shapes, concat_dim, operName);
		}
	}
}
