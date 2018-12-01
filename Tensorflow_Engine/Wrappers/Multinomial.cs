using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Multinomial(this TFGraph graph, TensorFlow.TFOutput logits, TensorFlow.TFOutput num_samples, long? seed=null, long? seed2=null, TensorFlow.TFDataType? output_dtype=null, string operName=null)
		{
			return graph.Multinomial(logits, num_samples, seed, seed2, output_dtype, operName);
		}
	}
}
