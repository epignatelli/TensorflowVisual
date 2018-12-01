using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AdjustContrastv2(this TFGraph graph, TensorFlow.TFOutput images, TensorFlow.TFOutput contrast_factor, string operName=null)
		{
			return graph.AdjustContrastv2(images, contrast_factor, operName);
		}
	}
}
