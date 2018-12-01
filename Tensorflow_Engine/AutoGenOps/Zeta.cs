using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Zeta(this TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput q, string operName=null)
		{
			return graph.Zeta(x, q, operName);
		}
	}
}
