using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation DestroyResourceOp(this TFGraph graph, TensorFlow.TFOutput resource, System.Boolean? ignore_lookup_error=null, string operName=null)
		{
			return graph.DestroyResourceOp(resource, ignore_lookup_error, operName);
		}
	}
}
