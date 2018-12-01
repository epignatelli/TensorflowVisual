using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput LookupTableFindV2(TFGraph graph, TensorFlow.TFOutput table_handle, TensorFlow.TFOutput keys, TensorFlow.TFOutput default_value, string operName=null)
		{
			return graph.LookupTableFindV2(table_handle, keys, default_value, operName);
		}
	}
}
