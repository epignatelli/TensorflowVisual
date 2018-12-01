using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput GlobalNorm(this TFGraph graph, TensorFlow.TFOutput[] tensors, string operName=null)
		{
			return graph.GlobalNorm(tensors, operName);
		}
	}
}
