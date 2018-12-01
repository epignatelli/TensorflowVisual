using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static long[] GetShape(TFGraph graph, TensorFlow.TFOutput output, TensorFlow.TFStatus status=null)
		{
			return graph.GetShape(output, status);
		}
	}
}
