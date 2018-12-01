using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation ResourceScatterAdd(TFGraph graph, TensorFlow.TFOutput resource, TensorFlow.TFOutput indices, TensorFlow.TFOutput updates, string operName=null)
		{
			return graph.ResourceScatterAdd(resource, indices, updates, operName);
		}
	}
}
