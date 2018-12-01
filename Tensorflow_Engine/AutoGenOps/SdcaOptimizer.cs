using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput[],TensorFlow.TFOutput[]> SdcaOptimizer(this TFGraph graph, TensorFlow.TFOutput[] sparse_example_indices, TensorFlow.TFOutput[] sparse_feature_indices, TensorFlow.TFOutput[] sparse_feature_values, TensorFlow.TFOutput[] dense_features, TensorFlow.TFOutput example_weights, TensorFlow.TFOutput example_labels, TensorFlow.TFOutput[] sparse_indices, TensorFlow.TFOutput[] sparse_weights, TensorFlow.TFOutput[] dense_weights, TensorFlow.TFOutput example_state_data, string loss_type, System.Single l1, System.Single l2, long num_loss_partitions, long num_inner_iterations, System.Boolean? adaptative=null, string operName=null)
		{
			return graph.SdcaOptimizer(sparse_example_indices, sparse_feature_indices, sparse_feature_values, dense_features, example_weights, example_labels, sparse_indices, sparse_weights, dense_weights, example_state_data, loss_type, l1, l2, num_loss_partitions, num_inner_iterations, adaptative, operName);
		}
	}
}
