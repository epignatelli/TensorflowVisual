using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput FakeQuantWithMinMaxVars(this TFGraph graph, TensorFlow.TFOutput inputs, TensorFlow.TFOutput min, TensorFlow.TFOutput max, long? num_bits=null, System.Boolean? narrow_range=null, string operName=null)
		{
			return graph.FakeQuantWithMinMaxVars(inputs, min, max, num_bits, narrow_range, operName);
		}
	}
}
