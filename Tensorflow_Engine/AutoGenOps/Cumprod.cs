using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Cumprod(this TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput axis, System.Boolean? exclusive=null, System.Boolean? reverse=null, string operName=null)
		{
			return graph.Cumprod(x, axis, exclusive, reverse, operName);
		}
	}
}
