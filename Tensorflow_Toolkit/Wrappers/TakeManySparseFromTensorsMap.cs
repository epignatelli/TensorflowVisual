using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> TakeManySparseFromTensorsMap(TFGraph graph, TensorFlow.TFOutput sparse_handles, TensorFlow.TFDataType dtype, string container=null, string shared_name=null, string operName=null)
		{
			return graph.TakeManySparseFromTensorsMap(sparse_handles, dtype, container, shared_name, operName);
		}
	}
}
