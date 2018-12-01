using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Log1p(this TFGraph graph, TensorFlow.TFOutput x, string operName=null)
		{
			return graph.Log1p(x, operName);
		}
	}
}
