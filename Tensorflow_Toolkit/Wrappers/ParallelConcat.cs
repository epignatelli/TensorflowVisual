using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ParallelConcat(TFGraph graph, TensorFlow.TFOutput[] values, TensorFlow.TFShape shape, string operName=null)
		{
			return graph.ParallelConcat(values, shape, operName);
		}
	}
}
