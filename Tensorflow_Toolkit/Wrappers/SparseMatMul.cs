using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SparseMatMul(TFGraph graph, TensorFlow.TFOutput a, TensorFlow.TFOutput b, System.Boolean? transpose_a=null, System.Boolean? transpose_b=null, System.Boolean? a_is_sparse=null, System.Boolean? b_is_sparse=null, string operName=null)
		{
			return graph.SparseMatMul(a, b, transpose_a, transpose_b, a_is_sparse, b_is_sparse, operName);
		}
	}
}
