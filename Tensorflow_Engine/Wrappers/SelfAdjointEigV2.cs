using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> SelfAdjointEigV2(this TFGraph graph, TensorFlow.TFOutput input, System.Boolean? compute_v=null, string operName=null)
		{
			return graph.SelfAdjointEigV2(input, compute_v, operName);
		}
	}
}
