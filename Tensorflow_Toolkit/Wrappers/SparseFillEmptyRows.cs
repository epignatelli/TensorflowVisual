using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> SparseFillEmptyRows(TFGraph graph, TensorFlow.TFOutput indices, TensorFlow.TFOutput values, TensorFlow.TFOutput dense_shape, TensorFlow.TFOutput default_value, string operName=null)
		{
			return graph.SparseFillEmptyRows(indices, values, dense_shape, default_value, operName);
		}
	}
}
