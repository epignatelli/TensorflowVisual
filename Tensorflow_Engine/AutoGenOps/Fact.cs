using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Fact(this TFGraph graph, string operName=null)
		{
			return graph.Fact(operName);
		}
	}
}
