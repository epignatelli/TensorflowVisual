using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AudioSpectrogram(this TFGraph graph, TensorFlow.TFOutput input, long window_size, long stride, System.Boolean? magnitude_squared=null, string operName=null)
		{
			return graph.AudioSpectrogram(input, window_size, stride, magnitude_squared, operName);
		}
	}
}
