using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> ThreadUnsafeUnigramCandidateSampler(this TFGraph graph, TensorFlow.TFOutput true_classes, long num_true, long num_sampled, System.Boolean unique, long range_max, long? seed=null, long? seed2=null, string operName=null)
		{
			return graph.ThreadUnsafeUnigramCandidateSampler(true_classes, num_true, num_sampled, unique, range_max, seed, seed2, operName);
		}
	}
}
