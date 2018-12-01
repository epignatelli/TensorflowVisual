using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SerializeIterator(TFGraph graph, TensorFlow.TFOutput resource_handle, string operName=null)
		{
			return graph.SerializeIterator(resource_handle, operName);
		}
	}
}
