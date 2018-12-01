using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MergeSummary(this TFGraph graph, TensorFlow.TFOutput[] inputs, string operName=null)
		{
			return graph.MergeSummary(inputs, operName);
		}
	}
}
