using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SparseTensorDenseMatMul(this TFGraph graph, TensorFlow.TFOutput a_indices, TensorFlow.TFOutput a_values, TensorFlow.TFOutput a_shape, TensorFlow.TFOutput b, System.Boolean? adjoint_a=null, System.Boolean? adjoint_b=null, string operName=null)
		{
			return graph.SparseTensorDenseMatMul(a_indices, a_values, a_shape, b, adjoint_a, adjoint_b, operName);
		}
	}
}
