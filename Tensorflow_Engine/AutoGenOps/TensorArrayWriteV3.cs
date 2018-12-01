using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorArrayWriteV3(this TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput index, TensorFlow.TFOutput value, TensorFlow.TFOutput flow_in, string operName=null)
		{
			return graph.TensorArrayWriteV3(handle, index, value, flow_in, operName);
		}
	}
}
