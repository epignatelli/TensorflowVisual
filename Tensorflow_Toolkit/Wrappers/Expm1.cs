using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Expm1(TFGraph graph, TensorFlow.TFOutput x, string operName=null)
		{
			return graph.Expm1(x, operName);
		}
	}
}
