using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TruncateDiv(TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput y, string operName=null)
		{
			return graph.TruncateDiv(x, y, operName);
		}
	}
}
