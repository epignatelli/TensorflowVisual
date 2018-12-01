using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation Assert(TFGraph graph, TensorFlow.TFOutput condition, TensorFlow.TFOutput[] data, long? summarize=null, string operName=null)
		{
			return graph.Assert(condition, data, summarize, operName);
		}
	}
}
