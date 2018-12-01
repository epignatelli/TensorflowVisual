using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Reshape(TFGraph graph, TensorFlow.TFOutput tensor, TensorFlow.TFOutput shape, string operName=null)
		{
			return graph.Reshape(tensor, shape, operName);
		}
	}
}
