using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation InitializeTable(TFGraph graph, TensorFlow.TFOutput table_handle, TensorFlow.TFOutput keys, TensorFlow.TFOutput values, string operName=null)
		{
			return graph.InitializeTable(table_handle, keys, values, operName);
		}
	}
}
