using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput GlobalNorm(TFGraph graph, TensorFlow.TFOutput[] tensors, string operName=null)
		{
			return graph.GlobalNorm(tensors, operName);
		}
	}
}
