using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput NthElement(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput n, System.Boolean? reverse=null, string operName=null)
		{
			return graph.NthElement(input, n, reverse, operName);
		}
	}
}
