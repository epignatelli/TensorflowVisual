using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> RefMerge(TFGraph graph, TensorFlow.TFOutput[] inputs, string operName=null)
		{
			return graph.RefMerge(inputs, operName);
		}
	}
}
