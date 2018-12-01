using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput[],TensorFlow.TFOutput[],TensorFlow.TFOutput[],TensorFlow.TFOutput[],TensorFlow.TFOutput[],TensorFlow.TFOutput[],TensorFlow.TFOutput[],ValueTuple<TensorFlow.TFOutput[]>> ParseSingleSequenceExample(TFGraph graph, TensorFlow.TFOutput serialized, TensorFlow.TFOutput feature_list_dense_missing_assumed_empty, TensorFlow.TFOutput[] context_sparse_keys, TensorFlow.TFOutput[] context_dense_keys, TensorFlow.TFOutput[] feature_list_sparse_keys, TensorFlow.TFOutput[] feature_list_dense_keys, TensorFlow.TFOutput[] context_dense_defaults, TensorFlow.TFOutput debug_name, TensorFlow.TFDataType[] context_sparse_types=null, TensorFlow.TFDataType[] feature_list_dense_types=null, TensorFlow.TFShape[] context_dense_shapes=null, TensorFlow.TFDataType[] feature_list_sparse_types=null, TensorFlow.TFShape[] feature_list_dense_shapes=null, string operName=null)
		{
			return graph.ParseSingleSequenceExample(serialized, feature_list_dense_missing_assumed_empty, context_sparse_keys, context_dense_keys, feature_list_sparse_keys, feature_list_dense_keys, context_dense_defaults, debug_name, context_sparse_types, feature_list_dense_types, context_dense_shapes, feature_list_sparse_types, feature_list_dense_shapes, operName);
		}
	}
}
