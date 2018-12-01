using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Atan2(TFGraph graph, TensorFlow.TFOutput y, TensorFlow.TFOutput x, string operName=null)
		{
			return graph.Atan2(y, x, operName);
		}
	}
}
