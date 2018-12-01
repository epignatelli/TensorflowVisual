using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorListElementShape(this TFGraph graph, TensorFlow.TFOutput input_handle, TensorFlow.TFDataType shape_type, string operName=null)
		{
			return graph.TensorListElementShape(input_handle, shape_type, operName);
		}
	}
}
