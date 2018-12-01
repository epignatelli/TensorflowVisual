using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> ComputeAccidentalHits(this TFGraph graph, TensorFlow.TFOutput true_classes, TensorFlow.TFOutput sampled_candidates, long num_true, long? seed=null, long? seed2=null, string operName=null)
		{
			return graph.ComputeAccidentalHits(true_classes, sampled_candidates, num_true, seed, seed2, operName);
		}
	}
}
