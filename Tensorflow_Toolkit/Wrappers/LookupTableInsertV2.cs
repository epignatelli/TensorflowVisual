using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation LookupTableInsertV2(TFGraph graph, TensorFlow.TFOutput table_handle, TensorFlow.TFOutput keys, TensorFlow.TFOutput values, string operName=null)
		{
			return graph.LookupTableInsertV2(table_handle, keys, values, operName);
		}
	}
}
