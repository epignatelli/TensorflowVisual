using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput CropAndResizeGradImage(TFGraph graph, TensorFlow.TFOutput grads, TensorFlow.TFOutput boxes, TensorFlow.TFOutput box_ind, TensorFlow.TFOutput image_size, TensorFlow.TFDataType T, string method=null, string operName=null)
		{
			return graph.CropAndResizeGradImage(grads, boxes, box_ind, image_size, T, method, operName);
		}
	}
}
