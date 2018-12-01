using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] ConcatOffset(TFGraph graph, TensorFlow.TFOutput concat_dim, TensorFlow.TFOutput[] shape, string operName=null)
		{
			return graph.ConcatOffset(concat_dim, shape, operName);
		}
	}
}
