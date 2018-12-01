using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput BatchMatMul(TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput y, System.Boolean? adj_x=null, System.Boolean? adj_y=null, string operName=null)
		{
			return graph.BatchMatMul(x, y, adj_x, adj_y, operName);
		}
	}
}
