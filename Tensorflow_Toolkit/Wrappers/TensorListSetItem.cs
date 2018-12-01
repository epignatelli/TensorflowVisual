using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorListSetItem(TFGraph graph, TensorFlow.TFOutput input_handle, TensorFlow.TFOutput index, TensorFlow.TFOutput item, string operName=null)
		{
			return graph.TensorListSetItem(input_handle, index, item, operName);
		}
	}
}
