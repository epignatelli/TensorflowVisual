using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput PlaceholderV2(TFGraph graph, TensorFlow.TFDataType dtype, TensorFlow.TFShape shape, string operName=null)
		{
			return graph.PlaceholderV2(dtype, shape, operName);
		}
	}
}
