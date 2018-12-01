using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Select(this TFGraph graph, TensorFlow.TFOutput condition, TensorFlow.TFOutput t, TensorFlow.TFOutput e, string operName=null)
		{
			return graph.Select(condition, t, e, operName);
		}
	}
}
