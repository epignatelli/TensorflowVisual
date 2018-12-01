using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ScatterNdNonAliasingAdd(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput indices, TensorFlow.TFOutput updates, string operName=null)
		{
			return graph.ScatterNdNonAliasingAdd(input, indices, updates, operName);
		}
	}
}
