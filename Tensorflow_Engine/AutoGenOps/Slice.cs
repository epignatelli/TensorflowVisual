using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Slice(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput begin, TensorFlow.TFOutput size, string operName=null)
		{
			return graph.Slice(input, begin, size, operName);
		}
	}
}
