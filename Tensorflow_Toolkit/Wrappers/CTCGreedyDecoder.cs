using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> CTCGreedyDecoder(TFGraph graph, TensorFlow.TFOutput inputs, TensorFlow.TFOutput sequence_length, System.Boolean? merge_repeated=null, string operName=null)
		{
			return graph.CTCGreedyDecoder(inputs, sequence_length, merge_repeated, operName);
		}
	}
}
