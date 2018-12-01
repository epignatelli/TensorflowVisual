using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ResourceCountUpTo(TFGraph graph, TensorFlow.TFOutput resource, long limit, TensorFlow.TFDataType T, string operName=null)
		{
			return graph.ResourceCountUpTo(resource, limit, T, operName);
		}
	}
}
