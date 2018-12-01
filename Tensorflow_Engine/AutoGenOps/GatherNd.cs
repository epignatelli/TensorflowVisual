using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput GatherNd(this TFGraph graph, TensorFlow.TFOutput parameters, TensorFlow.TFOutput indices, string operName=null)
		{
			return graph.GatherNd(parameters, indices, operName);
		}
	}
}
