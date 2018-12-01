using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorArraySplitV3(this TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput value, TensorFlow.TFOutput lengths, TensorFlow.TFOutput flow_in, string operName=null)
		{
			return graph.TensorArraySplitV3(handle, value, lengths, flow_in, operName);
		}
	}
}
