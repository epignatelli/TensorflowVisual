using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput[],TensorFlow.TFOutput[],TensorFlow.TFOutput[],TensorFlow.TFOutput> CTCBeamSearchDecoder(this TFGraph graph, TensorFlow.TFOutput inputs, TensorFlow.TFOutput sequence_length, long beam_width, long top_paths, System.Boolean? merge_repeated=null, string operName=null)
		{
			return graph.CTCBeamSearchDecoder(inputs, sequence_length, beam_width, top_paths, merge_repeated, operName);
		}
	}
}
