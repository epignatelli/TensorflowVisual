using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Pad(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput paddings, string operName=null)
		{
			return graph.Pad(input, paddings, operName);
		}
	}
}
