using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> Merge(TFGraph graph, TensorFlow.TFOutput[] inputs, string operName=null)
		{
			return graph.Merge(inputs, operName);
		}
	}
}
