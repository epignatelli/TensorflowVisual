using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Abs(this TFGraph graph, TensorFlow.TFOutput x, string operName=null)
		{
			return graph.Abs(x, operName);
		}
	}
}
