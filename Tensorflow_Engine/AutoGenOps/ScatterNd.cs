using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ScatterNd(this TFGraph graph, TensorFlow.TFOutput indices, TensorFlow.TFOutput updates, TensorFlow.TFOutput shape, string operName=null)
		{
			return graph.ScatterNd(indices, updates, shape, operName);
		}
	}
}
