using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MergeSummary(TFGraph graph, TensorFlow.TFOutput[] inputs, string operName=null)
		{
			return graph.MergeSummary(inputs, operName);
		}
	}
}
