using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SparseSegmentMeanWithNumSegments(this TFGraph graph, TensorFlow.TFOutput data, TensorFlow.TFOutput indices, TensorFlow.TFOutput segment_ids, TensorFlow.TFOutput num_segments, string operName=null)
		{
			return graph.SparseSegmentMeanWithNumSegments(data, indices, segment_ids, num_segments, operName);
		}
	}
}
