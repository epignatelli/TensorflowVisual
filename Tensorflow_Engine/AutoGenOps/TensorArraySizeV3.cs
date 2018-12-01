using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorArraySizeV3(this TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput flow_in, string operName=null)
		{
			return graph.TensorArraySizeV3(handle, flow_in, operName);
		}
	}
}
