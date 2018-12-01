using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput[]> OrderedMapUnstageNoKey(TFGraph graph, TensorFlow.TFOutput indices, TensorFlow.TFDataType[] dtypes, long? capacity=null, long? memory_limit=null, string container=null, string shared_name=null, string operName=null)
		{
			return graph.OrderedMapUnstageNoKey(indices, dtypes, capacity, memory_limit, container, shared_name, operName);
		}
	}
}
