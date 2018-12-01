using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Dequantize(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput min_range, TensorFlow.TFOutput max_range, string mode=null, string operName=null)
		{
			return graph.Dequantize(input, min_range, max_range, mode, operName);
		}
	}
}
