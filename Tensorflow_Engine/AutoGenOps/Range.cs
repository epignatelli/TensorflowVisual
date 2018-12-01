using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Range(this TFGraph graph, TensorFlow.TFOutput start, TensorFlow.TFOutput limit, TensorFlow.TFOutput delta, string operName=null)
		{
			return graph.Range(start, limit, delta, operName);
		}
	}
}
