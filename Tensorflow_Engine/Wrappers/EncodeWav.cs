using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput EncodeWav(this TFGraph graph, TensorFlow.TFOutput audio, TensorFlow.TFOutput sample_rate, string operName=null)
		{
			return graph.EncodeWav(audio, sample_rate, operName);
		}
	}
}
