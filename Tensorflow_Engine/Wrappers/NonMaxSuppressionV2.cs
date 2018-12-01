using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput NonMaxSuppressionV2(this TFGraph graph, TensorFlow.TFOutput boxes, TensorFlow.TFOutput scores, TensorFlow.TFOutput max_output_size, TensorFlow.TFOutput iou_threshold, string operName=null)
		{
			return graph.NonMaxSuppressionV2(boxes, scores, max_output_size, iou_threshold, operName);
		}
	}
}
