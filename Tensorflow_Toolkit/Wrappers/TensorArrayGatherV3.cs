using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorArrayGatherV3(TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput indices, TensorFlow.TFOutput flow_in, TensorFlow.TFDataType dtype, TensorFlow.TFShape element_shape=null, string operName=null)
		{
			return graph.TensorArrayGatherV3(handle, indices, flow_in, dtype, element_shape, operName);
		}
	}
}