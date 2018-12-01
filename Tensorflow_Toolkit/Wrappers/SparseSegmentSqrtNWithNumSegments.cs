using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SparseSegmentSqrtNWithNumSegments(TFGraph graph, TensorFlow.TFOutput data, TensorFlow.TFOutput indices, TensorFlow.TFOutput segment_ids, TensorFlow.TFOutput num_segments, string operName=null)
		{
			return graph.SparseSegmentSqrtNWithNumSegments(data, indices, segment_ids, num_segments, operName);
		}
	}
}
