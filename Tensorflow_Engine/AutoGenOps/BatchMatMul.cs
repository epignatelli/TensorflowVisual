using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput BatchMatMul(this TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput y, System.Boolean? adj_x=null, System.Boolean? adj_y=null, string operName=null)
		{
			return graph.BatchMatMul(x, y, adj_x, adj_y, operName);
		}
	}
}
