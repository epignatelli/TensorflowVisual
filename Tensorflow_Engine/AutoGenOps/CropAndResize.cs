using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput CropAndResize(this TFGraph graph, TensorFlow.TFOutput image, TensorFlow.TFOutput boxes, TensorFlow.TFOutput box_ind, TensorFlow.TFOutput crop_size, string method=null, System.Single? extrapolation_value=null, string operName=null)
		{
			return graph.CropAndResize(image, boxes, box_ind, crop_size, method, extrapolation_value, operName);
		}
	}
}
