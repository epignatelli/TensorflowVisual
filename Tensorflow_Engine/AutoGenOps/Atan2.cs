using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Atan2(this TFGraph graph, TensorFlow.TFOutput y, TensorFlow.TFOutput x, string operName=null)
		{
			return graph.Atan2(y, x, operName);
		}
	}
}
