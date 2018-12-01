using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorArrayWriteV3(TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput index, TensorFlow.TFOutput value, TensorFlow.TFOutput flow_in, string operName=null)
		{
			return graph.TensorArrayWriteV3(handle, index, value, flow_in, operName);
		}
	}
}
