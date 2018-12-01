using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation DeserializeIterator(TFGraph graph, TensorFlow.TFOutput resource_handle, TensorFlow.TFOutput serialized, string operName=null)
		{
			return graph.DeserializeIterator(resource_handle, serialized, operName);
		}
	}
}
