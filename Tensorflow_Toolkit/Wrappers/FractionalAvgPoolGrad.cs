using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput FractionalAvgPoolGrad(TFGraph graph, TensorFlow.TFOutput orig_input_tensor_shape, TensorFlow.TFOutput out_backprop, TensorFlow.TFOutput row_pooling_sequence, TensorFlow.TFOutput col_pooling_sequence, System.Boolean? overlapping=null, string operName=null)
		{
			return graph.FractionalAvgPoolGrad(orig_input_tensor_shape, out_backprop, row_pooling_sequence, col_pooling_sequence, overlapping, operName);
		}
	}
}
