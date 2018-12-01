using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput FractionalAvgPoolGrad(this TFGraph graph, TensorFlow.TFOutput orig_input_tensor_shape, TensorFlow.TFOutput out_backprop, TensorFlow.TFOutput row_pooling_sequence, TensorFlow.TFOutput col_pooling_sequence, System.Boolean? overlapping=null, string operName=null)
		{
			return graph.FractionalAvgPoolGrad(orig_input_tensor_shape, out_backprop, row_pooling_sequence, col_pooling_sequence, overlapping, operName);
		}
	}
}
