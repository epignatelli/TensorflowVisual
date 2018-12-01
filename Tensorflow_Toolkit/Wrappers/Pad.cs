using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Pad(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput paddings, string operName=null)
		{
			return graph.Pad(input, paddings, operName);
		}
	}
}
