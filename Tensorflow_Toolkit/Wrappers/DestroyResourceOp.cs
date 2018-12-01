using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation DestroyResourceOp(TFGraph graph, TensorFlow.TFOutput resource, System.Boolean? ignore_lookup_error=null, string operName=null)
		{
			return graph.DestroyResourceOp(resource, ignore_lookup_error, operName);
		}
	}
}
