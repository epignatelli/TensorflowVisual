using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> DeserializeSparse(TFGraph graph, TensorFlow.TFOutput serialized_sparse, TensorFlow.TFDataType dtype, string operName=null)
		{
			return graph.DeserializeSparse(serialized_sparse, dtype, operName);
		}
	}
}
