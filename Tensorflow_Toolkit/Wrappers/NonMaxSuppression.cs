using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput NonMaxSuppression(TFGraph graph, TensorFlow.TFOutput boxes, TensorFlow.TFOutput scores, TensorFlow.TFOutput max_output_size, System.Single? iou_threshold=null, string operName=null)
		{
			return graph.NonMaxSuppression(boxes, scores, max_output_size, iou_threshold, operName);
		}
	}
}
