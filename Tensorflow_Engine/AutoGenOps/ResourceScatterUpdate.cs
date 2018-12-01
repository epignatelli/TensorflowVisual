using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation ResourceScatterUpdate(this TFGraph graph, TensorFlow.TFOutput resource, TensorFlow.TFOutput indices, TensorFlow.TFOutput updates, string operName=null)
		{
			return graph.ResourceScatterUpdate(resource, indices, updates, operName);
		}
	}
}
