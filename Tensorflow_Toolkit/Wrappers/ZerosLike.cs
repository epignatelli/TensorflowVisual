using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ZerosLike(TFGraph graph, TensorFlow.TFOutput x, string operName=null)
		{
			return graph.ZerosLike(x, operName);
		}
	}
}
