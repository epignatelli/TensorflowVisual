using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation ResourceScatterUpdate(TFGraph graph, TensorFlow.TFOutput resource, TensorFlow.TFOutput indices, TensorFlow.TFOutput updates, string operName=null)
		{
			return graph.ResourceScatterUpdate(resource, indices, updates, operName);
		}
	}
}
