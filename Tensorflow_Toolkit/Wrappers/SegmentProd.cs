using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SegmentProd(TFGraph graph, TensorFlow.TFOutput data, TensorFlow.TFOutput segment_ids, string operName=null)
		{
			return graph.SegmentProd(data, segment_ids, operName);
		}
	}
}
