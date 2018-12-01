using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AudioSummaryV2(TFGraph graph, TensorFlow.TFOutput tag, TensorFlow.TFOutput tensor, TensorFlow.TFOutput sample_rate, long? max_outputs=null, string operName=null)
		{
			return graph.AudioSummaryV2(tag, tensor, sample_rate, max_outputs, operName);
		}
	}
}
