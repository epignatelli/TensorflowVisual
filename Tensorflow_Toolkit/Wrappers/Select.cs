using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Select(TFGraph graph, TensorFlow.TFOutput condition, TensorFlow.TFOutput t, TensorFlow.TFOutput e, string operName=null)
		{
			return graph.Select(condition, t, e, operName);
		}
	}
}
