using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Cumprod(TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput axis, System.Boolean? exclusive=null, System.Boolean? reverse=null, string operName=null)
		{
			return graph.Cumprod(x, axis, exclusive, reverse, operName);
		}
	}
}
