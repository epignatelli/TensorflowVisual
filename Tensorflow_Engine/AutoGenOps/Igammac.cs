using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Igammac(this TFGraph graph, TensorFlow.TFOutput a, TensorFlow.TFOutput x, string operName=null)
		{
			return graph.Igammac(a, x, operName);
		}
	}
}
