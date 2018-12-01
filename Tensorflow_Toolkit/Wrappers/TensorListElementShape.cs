using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorListElementShape(TFGraph graph, TensorFlow.TFOutput input_handle, TensorFlow.TFDataType shape_type, string operName=null)
		{
			return graph.TensorListElementShape(input_handle, shape_type, operName);
		}
	}
}
