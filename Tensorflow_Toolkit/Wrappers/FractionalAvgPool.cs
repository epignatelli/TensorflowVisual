using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> FractionalAvgPool(TFGraph graph, TensorFlow.TFOutput value, System.Single[] pooling_ratio, System.Boolean? pseudo_random=null, System.Boolean? overlapping=null, System.Boolean? deterministic=null, long? seed=null, long? seed2=null, string operName=null)
		{
			return graph.FractionalAvgPool(value, pooling_ratio, pseudo_random, overlapping, deterministic, seed, seed2, operName);
		}
	}
}
