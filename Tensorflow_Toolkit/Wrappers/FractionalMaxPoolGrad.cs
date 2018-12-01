using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput FractionalMaxPoolGrad(TFGraph graph, TensorFlow.TFOutput orig_input, TensorFlow.TFOutput orig_output, TensorFlow.TFOutput out_backprop, TensorFlow.TFOutput row_pooling_sequence, TensorFlow.TFOutput col_pooling_sequence, System.Boolean? overlapping=null, string operName=null)
		{
			return graph.FractionalMaxPoolGrad(orig_input, orig_output, out_backprop, row_pooling_sequence, col_pooling_sequence, overlapping, operName);
		}
	}
}
