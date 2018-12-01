using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Asin(this TFGraph graph, TensorFlow.TFOutput x, string operName=null)
		{
			return graph.Asin(x, operName);
		}
	}
}
