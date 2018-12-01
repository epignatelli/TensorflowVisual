using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> DeserializeSparse(this TFGraph graph, TensorFlow.TFOutput serialized_sparse, TensorFlow.TFDataType dtype, string operName=null)
		{
			return graph.DeserializeSparse(serialized_sparse, dtype, operName);
		}
	}
}
