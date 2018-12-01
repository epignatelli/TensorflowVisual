using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorListSetItem(this TFGraph graph, TensorFlow.TFOutput input_handle, TensorFlow.TFOutput index, TensorFlow.TFOutput item, string operName=null)
		{
			return graph.TensorListSetItem(input_handle, index, item, operName);
		}
	}
}
