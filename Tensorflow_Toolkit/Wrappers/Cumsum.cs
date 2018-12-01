using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Cumsum(TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput axis, System.Boolean? exclusive=null, System.Boolean? reverse=null, string operName=null)
		{
			return graph.Cumsum(x, axis, exclusive, reverse, operName);
		}
	}
}
