using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DynamicStitch(TFGraph graph, TensorFlow.TFOutput[] indices, TensorFlow.TFOutput[] data, string operName=null)
		{
			return graph.DynamicStitch(indices, data, operName);
		}
	}
}
