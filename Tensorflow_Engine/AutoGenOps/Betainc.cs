using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Betainc(this TFGraph graph, TensorFlow.TFOutput a, TensorFlow.TFOutput b, TensorFlow.TFOutput x, string operName=null)
		{
			return graph.Betainc(a, b, x, operName);
		}
	}
}
