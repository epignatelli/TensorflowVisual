using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput UnsortedSegmentProd(TFGraph graph, TensorFlow.TFOutput data, TensorFlow.TFOutput segment_ids, TensorFlow.TFOutput num_segments, string operName=null)
		{
			return graph.UnsortedSegmentProd(data, segment_ids, num_segments, operName);
		}
	}
}
