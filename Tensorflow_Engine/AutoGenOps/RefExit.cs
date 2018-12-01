using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RefExit(this TFGraph graph, TensorFlow.TFOutput data, string operName=null)
		{
			return graph.RefExit(data, operName);
		}
	}
}
