using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ScalarSummary(this TFGraph graph, TensorFlow.TFOutput tags, TensorFlow.TFOutput values, string operName=null)
		{
			return graph.ScalarSummary(tags, values, operName);
		}
	}
}
