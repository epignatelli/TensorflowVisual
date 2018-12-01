using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput FakeQuantWithMinMaxArgs(this TFGraph graph, TensorFlow.TFOutput inputs, System.Single? min=null, System.Single? max=null, long? num_bits=null, System.Boolean? narrow_range=null, string operName=null)
		{
			return graph.FakeQuantWithMinMaxArgs(inputs, min, max, num_bits, narrow_range, operName);
		}
	}
}
