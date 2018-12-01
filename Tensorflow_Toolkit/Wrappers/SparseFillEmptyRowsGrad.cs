using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> SparseFillEmptyRowsGrad(TFGraph graph, TensorFlow.TFOutput reverse_index_map, TensorFlow.TFOutput grad_values, string operName=null)
		{
			return graph.SparseFillEmptyRowsGrad(reverse_index_map, grad_values, operName);
		}
	}
}
