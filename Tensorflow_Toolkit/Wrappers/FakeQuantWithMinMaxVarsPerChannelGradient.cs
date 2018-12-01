using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> FakeQuantWithMinMaxVarsPerChannelGradient(TFGraph graph, TensorFlow.TFOutput gradients, TensorFlow.TFOutput inputs, TensorFlow.TFOutput min, TensorFlow.TFOutput max, long? num_bits=null, System.Boolean? narrow_range=null, string operName=null)
		{
			return graph.FakeQuantWithMinMaxVarsPerChannelGradient(gradients, inputs, min, max, num_bits, narrow_range, operName);
		}
	}
}
