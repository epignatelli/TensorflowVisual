using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Minimum(TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput y, string operName=null)
		{
			return graph.Minimum(x, y, operName);
		}
	}
}
