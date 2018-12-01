using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ZerosLike(this TFGraph graph, TensorFlow.TFOutput x, string operName=null)
		{
			return graph.ZerosLike(x, operName);
		}
	}
}
