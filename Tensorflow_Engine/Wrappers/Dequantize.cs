using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Dequantize(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput min_range, TensorFlow.TFOutput max_range, string mode=null, string operName=null)
		{
			return graph.Dequantize(input, min_range, max_range, mode, operName);
		}
	}
}
