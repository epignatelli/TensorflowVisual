using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Softmax(TFGraph graph, TensorFlow.TFOutput logits, string operName=null)
		{
			return graph.Softmax(logits, operName);
		}
	}
}
