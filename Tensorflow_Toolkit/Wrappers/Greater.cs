using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Greater(TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput y, string operName=null)
		{
			return graph.Greater(x, y, operName);
		}
	}
}
