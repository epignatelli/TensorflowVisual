using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AdjustContrast(TFGraph graph, TensorFlow.TFOutput images, TensorFlow.TFOutput contrast_factor, TensorFlow.TFOutput min_value, TensorFlow.TFOutput max_value, string operName=null)
		{
			return graph.AdjustContrast(images, contrast_factor, min_value, max_value, operName);
		}
	}
}
