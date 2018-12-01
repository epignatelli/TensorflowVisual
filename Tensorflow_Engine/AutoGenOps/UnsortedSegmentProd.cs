using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput UnsortedSegmentProd(this TFGraph graph, TensorFlow.TFOutput data, TensorFlow.TFOutput segment_ids, TensorFlow.TFOutput num_segments, string operName=null)
		{
			return graph.UnsortedSegmentProd(data, segment_ids, num_segments, operName);
		}
	}
}
