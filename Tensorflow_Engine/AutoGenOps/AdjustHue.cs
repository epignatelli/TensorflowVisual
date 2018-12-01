using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AdjustHue(this TFGraph graph, TensorFlow.TFOutput images, TensorFlow.TFOutput delta, string operName=null)
		{
			return graph.AdjustHue(images, delta, operName);
		}
	}
}
