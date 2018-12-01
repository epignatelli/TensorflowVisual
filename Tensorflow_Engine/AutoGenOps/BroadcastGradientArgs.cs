using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> BroadcastGradientArgs(this TFGraph graph, TensorFlow.TFOutput s0, TensorFlow.TFOutput s1, string operName=null)
		{
			return graph.BroadcastGradientArgs(s0, s1, operName);
		}
	}
}
