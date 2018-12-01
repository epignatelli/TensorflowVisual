using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> FractionalMaxPool(this TFGraph graph, TensorFlow.TFOutput value, System.Single[] pooling_ratio, System.Boolean? pseudo_random=null, System.Boolean? overlapping=null, System.Boolean? deterministic=null, long? seed=null, long? seed2=null, string operName=null)
		{
			return graph.FractionalMaxPool(value, pooling_ratio, pseudo_random, overlapping, deterministic, seed, seed2, operName);
		}
	}
}
