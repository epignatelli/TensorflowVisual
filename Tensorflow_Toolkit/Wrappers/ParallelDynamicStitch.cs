using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ParallelDynamicStitch(TFGraph graph, TensorFlow.TFOutput[] indices, TensorFlow.TFOutput[] data, string operName=null)
		{
			return graph.ParallelDynamicStitch(indices, data, operName);
		}
	}
}
