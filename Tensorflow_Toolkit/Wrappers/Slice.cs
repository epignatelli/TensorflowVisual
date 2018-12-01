using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Slice(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput begin, TensorFlow.TFOutput size, string operName=null)
		{
			return graph.Slice(input, begin, size, operName);
		}
	}
}
