using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorSummaryV2(this TFGraph graph, TensorFlow.TFOutput tag, TensorFlow.TFOutput tensor, TensorFlow.TFOutput serialized_summary_metadata, string operName=null)
		{
			return graph.TensorSummaryV2(tag, tensor, serialized_summary_metadata, operName);
		}
	}
}
