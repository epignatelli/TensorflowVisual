using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Log1p(TFGraph graph, TensorFlow.TFOutput x, string operName=null)
		{
			return graph.Log1p(x, operName);
		}
	}
}
