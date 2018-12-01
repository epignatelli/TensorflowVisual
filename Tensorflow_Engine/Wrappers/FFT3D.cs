using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput FFT3D(this TFGraph graph, TensorFlow.TFOutput input, string operName=null)
		{
			return graph.FFT3D(input, operName);
		}
	}
}
