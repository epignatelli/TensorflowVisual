using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation DeserializeIterator(this TFGraph graph, TensorFlow.TFOutput resource_handle, TensorFlow.TFOutput serialized, string operName=null)
		{
			return graph.DeserializeIterator(resource_handle, serialized, operName);
		}
	}
}
