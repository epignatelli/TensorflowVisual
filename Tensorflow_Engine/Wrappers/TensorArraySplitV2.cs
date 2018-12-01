using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorArraySplitV2(this TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput value, TensorFlow.TFOutput lengths, TensorFlow.TFOutput flow_in, string operName=null)
		{
			return graph.TensorArraySplitV2(handle, value, lengths, flow_in, operName);
		}
	}
}
