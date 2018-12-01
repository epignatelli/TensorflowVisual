using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorListPushBack(TFGraph graph, TensorFlow.TFOutput input_handle, TensorFlow.TFOutput tensor, string operName=null)
		{
			return graph.TensorListPushBack(input_handle, tensor, operName);
		}
	}
}
