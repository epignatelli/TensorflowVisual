using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput UnsortedSegmentMax(TFGraph graph, TensorFlow.TFOutput data, TensorFlow.TFOutput segment_ids, TensorFlow.TFOutput num_segments, string operName=null)
		{
			return graph.UnsortedSegmentMax(data, segment_ids, num_segments, operName);
		}
	}
}
