using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput FFT2D(this TFGraph graph, TensorFlow.TFOutput input, string operName=null)
		{
			return graph.FFT2D(input, operName);
		}
	}
}
