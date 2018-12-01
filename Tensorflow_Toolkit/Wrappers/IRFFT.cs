using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput IRFFT(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput fft_length, string operName=null)
		{
			return graph.IRFFT(input, fft_length, operName);
		}
	}
}
