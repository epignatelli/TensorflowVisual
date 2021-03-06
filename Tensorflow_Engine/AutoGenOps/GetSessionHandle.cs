using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput GetSessionHandle(this TFGraph graph, TensorFlow.TFOutput value, string operName=null)
		{
			return graph.GetSessionHandle(value, operName);
		}
	}
}
