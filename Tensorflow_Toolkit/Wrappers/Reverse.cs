using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Reverse(TFGraph graph, TensorFlow.TFOutput tensor, TensorFlow.TFOutput dims, string operName=null)
		{
			return graph.Reverse(tensor, dims, operName);
		}
	}
}
