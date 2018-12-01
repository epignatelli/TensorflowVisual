using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput[],TensorFlow.TFOutput[],TensorFlow.TFOutput[],TensorFlow.TFOutput[]> ParseSingleExample(TFGraph graph, TensorFlow.TFOutput serialized, TensorFlow.TFOutput[] dense_defaults, long num_sparse, string[] sparse_keys, string[] dense_keys, TensorFlow.TFDataType[] sparse_types, TensorFlow.TFShape[] dense_shapes, string operName=null)
		{
			return graph.ParseSingleExample(serialized, dense_defaults, num_sparse, sparse_keys, dense_keys, sparse_types, dense_shapes, operName);
		}
	}
}
