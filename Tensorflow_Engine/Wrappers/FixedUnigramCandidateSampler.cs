using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> FixedUnigramCandidateSampler(this TFGraph graph, TensorFlow.TFOutput true_classes, long num_true, long num_sampled, System.Boolean unique, long range_max, string vocab_file=null, System.Single? distortion=null, long? num_reserved_ids=null, long? num_shards=null, long? shard=null, System.Single[] unigrams=null, long? seed=null, long? seed2=null, string operName=null)
		{
			return graph.FixedUnigramCandidateSampler(true_classes, num_true, num_sampled, unique, range_max, vocab_file, distortion, num_reserved_ids, num_shards, shard, unigrams, seed, seed2, operName);
		}
	}
}
