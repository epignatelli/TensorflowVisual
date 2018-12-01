using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ResourceCountUpTo(this TFGraph graph, TensorFlow.TFOutput resource, long limit, TensorFlow.TFDataType T, string operName=null)
		{
			return graph.ResourceCountUpTo(resource, limit, T, operName);
		}
	}
}
