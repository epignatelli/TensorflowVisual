using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> AllCandidateSampler(this TFGraph graph, TensorFlow.TFOutput true_classes, long num_true, long num_sampled, System.Boolean unique, long? seed=null, long? seed2=null, string operName=null)
		{
			return graph.AllCandidateSampler(true_classes, num_true, num_sampled, unique, seed, seed2, operName);
		}
	}
}
