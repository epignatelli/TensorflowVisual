using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput BroadcastArgs(this TFGraph graph, TensorFlow.TFOutput s0, TensorFlow.TFOutput s1, string operName=null)
		{
			return graph.BroadcastArgs(s0, s1, operName);
		}
	}
}
