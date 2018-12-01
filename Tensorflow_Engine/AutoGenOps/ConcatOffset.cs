using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] ConcatOffset(this TFGraph graph, TensorFlow.TFOutput concat_dim, TensorFlow.TFOutput[] shape, string operName=null)
		{
			return graph.ConcatOffset(concat_dim, shape, operName);
		}
	}
}
