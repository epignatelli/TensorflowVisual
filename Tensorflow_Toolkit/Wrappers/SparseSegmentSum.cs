using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SparseSegmentSum(TFGraph graph, TensorFlow.TFOutput data, TensorFlow.TFOutput indices, TensorFlow.TFOutput segment_ids, string operName=null)
		{
			return graph.SparseSegmentSum(data, indices, segment_ids, operName);
		}
	}
}
