using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SegmentMin(TFGraph graph, TensorFlow.TFOutput data, TensorFlow.TFOutput segment_ids, string operName=null)
		{
			return graph.SegmentMin(data, segment_ids, operName);
		}
	}
}
