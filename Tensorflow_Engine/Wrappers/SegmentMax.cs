using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SegmentMax(this TFGraph graph, TensorFlow.TFOutput data, TensorFlow.TFOutput segment_ids, string operName=null)
		{
			return graph.SegmentMax(data, segment_ids, operName);
		}
	}
}
