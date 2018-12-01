using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation TensorArrayCloseV2(this TFGraph graph, TensorFlow.TFOutput handle, string operName=null)
		{
			return graph.TensorArrayCloseV2(handle, operName);
		}
	}
}
