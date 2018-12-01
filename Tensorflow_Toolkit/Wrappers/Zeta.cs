using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Zeta(TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput q, string operName=null)
		{
			return graph.Zeta(x, q, operName);
		}
	}
}
