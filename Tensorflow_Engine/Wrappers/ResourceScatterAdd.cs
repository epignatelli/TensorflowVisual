using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation ResourceScatterAdd(this TFGraph graph, TensorFlow.TFOutput resource, TensorFlow.TFOutput indices, TensorFlow.TFOutput updates, string operName=null)
		{
			return graph.ResourceScatterAdd(resource, indices, updates, operName);
		}
	}
}
