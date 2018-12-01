using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AdjustContrastv2(TFGraph graph, TensorFlow.TFOutput images, TensorFlow.TFOutput contrast_factor, string operName=null)
		{
			return graph.AdjustContrastv2(images, contrast_factor, operName);
		}
	}
}
