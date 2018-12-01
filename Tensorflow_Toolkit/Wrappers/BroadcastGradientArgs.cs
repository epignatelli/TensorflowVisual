using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> BroadcastGradientArgs(TFGraph graph, TensorFlow.TFOutput s0, TensorFlow.TFOutput s1, string operName=null)
		{
			return graph.BroadcastGradientArgs(s0, s1, operName);
		}
	}
}
