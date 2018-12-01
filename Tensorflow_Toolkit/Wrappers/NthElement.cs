using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput NthElement(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput n, System.Boolean? reverse=null, string operName=null)
		{
			return graph.NthElement(input, n, reverse, operName);
		}
	}
}
