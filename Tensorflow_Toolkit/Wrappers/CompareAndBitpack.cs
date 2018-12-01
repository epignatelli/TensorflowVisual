using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput CompareAndBitpack(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput threshold, string operName=null)
		{
			return graph.CompareAndBitpack(input, threshold, operName);
		}
	}
}
