using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Neg(TFGraph graph, TensorFlow.TFOutput x, string operName=null)
		{
			return graph.Neg(x, operName);
		}
	}
}
