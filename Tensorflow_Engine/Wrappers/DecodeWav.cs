using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> DecodeWav(this TFGraph graph, TensorFlow.TFOutput contents, long? desired_channels=null, long? desired_samples=null, string operName=null)
		{
			return graph.DecodeWav(contents, desired_channels, desired_samples, operName);
		}
	}
}
