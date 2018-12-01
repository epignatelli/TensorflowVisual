using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Roll(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput shift, TensorFlow.TFOutput axis, string operName=null)
		{
			return graph.Roll(input, shift, axis, operName);
		}
	}
}
