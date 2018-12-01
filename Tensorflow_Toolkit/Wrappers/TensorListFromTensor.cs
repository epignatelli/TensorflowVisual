using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorListFromTensor(TFGraph graph, TensorFlow.TFOutput tensor, TensorFlow.TFOutput element_shape, string operName=null)
		{
			return graph.TensorListFromTensor(tensor, element_shape, operName);
		}
	}
}
