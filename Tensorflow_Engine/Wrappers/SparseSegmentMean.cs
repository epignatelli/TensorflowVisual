using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SparseSegmentMean(this TFGraph graph, TensorFlow.TFOutput data, TensorFlow.TFOutput indices, TensorFlow.TFOutput segment_ids, string operName=null)
		{
			return graph.SparseSegmentMean(data, indices, segment_ids, operName);
		}
	}
}
