using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Concat(this TFGraph graph, TensorFlow.TFOutput concat_dim, TensorFlow.TFOutput[] values, string operName=null)
		{
			return graph.Concat(concat_dim, values, operName);
		}
	}
}
