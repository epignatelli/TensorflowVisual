using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AudioSpectrogram(TFGraph graph, TensorFlow.TFOutput input, long window_size, long stride, System.Boolean? magnitude_squared=null, string operName=null)
		{
			return graph.AudioSpectrogram(input, window_size, stride, magnitude_squared, operName);
		}
	}
}
