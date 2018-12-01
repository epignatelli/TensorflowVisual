using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AudioSummary(TFGraph graph, TensorFlow.TFOutput tag, TensorFlow.TFOutput tensor, System.Single sample_rate, long? max_outputs=null, string operName=null)
		{
			return graph.AudioSummary(tag, tensor, sample_rate, max_outputs, operName);
		}
	}
}
