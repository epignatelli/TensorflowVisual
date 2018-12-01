using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput EditDistance(this TFGraph graph, TensorFlow.TFOutput hypothesis_indices, TensorFlow.TFOutput hypothesis_values, TensorFlow.TFOutput hypothesis_shape, TensorFlow.TFOutput truth_indices, TensorFlow.TFOutput truth_values, TensorFlow.TFOutput truth_shape, System.Boolean? normalize=null, string operName=null)
		{
			return graph.EditDistance(hypothesis_indices, hypothesis_values, hypothesis_shape, truth_indices, truth_values, truth_shape, normalize, operName);
		}
	}
}
