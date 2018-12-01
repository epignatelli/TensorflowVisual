using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AdjustSaturation(TFGraph graph, TensorFlow.TFOutput images, TensorFlow.TFOutput scale, string operName=null)
		{
			return graph.AdjustSaturation(images, scale, operName);
		}
	}
}
