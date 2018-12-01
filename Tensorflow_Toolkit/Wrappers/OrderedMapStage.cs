using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation OrderedMapStage(TFGraph graph, TensorFlow.TFOutput key, TensorFlow.TFOutput indices, TensorFlow.TFOutput[] values, TensorFlow.TFDataType[] dtypes, long? capacity=null, long? memory_limit=null, string container=null, string shared_name=null, string operName=null)
		{
			return graph.OrderedMapStage(key, indices, values, dtypes, capacity, memory_limit, container, shared_name, operName);
		}
	}
}
