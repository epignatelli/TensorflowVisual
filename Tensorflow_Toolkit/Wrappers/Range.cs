using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Range(TFGraph graph, TensorFlow.TFOutput start, TensorFlow.TFOutput limit, TensorFlow.TFOutput delta, string operName=null)
		{
			return graph.Range(start, limit, delta, operName);
		}
	}
}
