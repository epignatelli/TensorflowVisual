using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SparseDenseCwiseAdd(TFGraph graph, TensorFlow.TFOutput sp_indices, TensorFlow.TFOutput sp_values, TensorFlow.TFOutput sp_shape, TensorFlow.TFOutput dense, string operName=null)
		{
			return graph.SparseDenseCwiseAdd(sp_indices, sp_values, sp_shape, dense, operName);
		}
	}
}
