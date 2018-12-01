using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput GetSessionHandleV2(this TFGraph graph, TensorFlow.TFOutput value, string operName=null)
		{
			return graph.GetSessionHandleV2(value, operName);
		}
	}
}
