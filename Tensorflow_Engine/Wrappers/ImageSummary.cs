using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ImageSummary(this TFGraph graph, TensorFlow.TFOutput tag, TensorFlow.TFOutput tensor, long? max_images=null, TensorFlow.TFTensor bad_color=null, string operName=null)
		{
			return graph.ImageSummary(tag, tensor, max_images, bad_color, operName);
		}
	}
}
