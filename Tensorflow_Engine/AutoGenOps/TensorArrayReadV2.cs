using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorArrayReadV2(this TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput index, TensorFlow.TFOutput flow_in, TensorFlow.TFDataType dtype, string operName=null)
		{
			return graph.TensorArrayReadV2(handle, index, flow_in, dtype, operName);
		}
	}
}
