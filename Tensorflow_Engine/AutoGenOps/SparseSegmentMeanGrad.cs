using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SparseSegmentMeanGrad(this TFGraph graph, TensorFlow.TFOutput grad, TensorFlow.TFOutput indices, TensorFlow.TFOutput segment_ids, TensorFlow.TFOutput output_dim0, string operName=null)
		{
			return graph.SparseSegmentMeanGrad(grad, indices, segment_ids, output_dim0, operName);
		}
	}
}
