using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> GenerateVocabRemapping(TFGraph graph, TensorFlow.TFOutput new_vocab_file, TensorFlow.TFOutput old_vocab_file, long new_vocab_offset, long num_new_vocab, long? old_vocab_size=null, string operName=null)
		{
			return graph.GenerateVocabRemapping(new_vocab_file, old_vocab_file, new_vocab_offset, num_new_vocab, old_vocab_size, operName);
		}
	}
}
