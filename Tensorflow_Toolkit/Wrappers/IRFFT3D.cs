using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput IRFFT3D(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput fft_length, string operName=null)
		{
			return graph.IRFFT3D(input, fft_length, operName);
		}
	}
}
