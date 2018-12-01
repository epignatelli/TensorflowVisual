using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AdjustHue(TFGraph graph, TensorFlow.TFOutput images, TensorFlow.TFOutput delta, string operName=null)
		{
			return graph.AdjustHue(images, delta, operName);
		}
	}
}
