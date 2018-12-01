using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput FakeQuantWithMinMaxVarsPerChannel(this TFGraph graph, TensorFlow.TFOutput inputs, TensorFlow.TFOutput min, TensorFlow.TFOutput max, long? num_bits=null, System.Boolean? narrow_range=null, string operName=null)
		{
			return graph.FakeQuantWithMinMaxVarsPerChannel(inputs, min, max, num_bits, narrow_range, operName);
		}
	}
}
