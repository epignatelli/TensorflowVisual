using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorArraySizeV2(TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput flow_in, string operName=null)
		{
			return graph.TensorArraySizeV2(handle, flow_in, operName);
		}
	}
}
