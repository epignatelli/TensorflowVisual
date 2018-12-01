using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> QuantizedInstanceNorm(this TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput x_min, TensorFlow.TFOutput x_max, System.Boolean? output_range_given=null, System.Single? given_y_min=null, System.Single? given_y_max=null, System.Single? variance_epsilon=null, System.Single? min_separation=null, string operName=null)
		{
			return graph.QuantizedInstanceNorm(x, x_min, x_max, output_range_given, given_y_min, given_y_max, variance_epsilon, min_separation, operName);
		}
	}
}
