using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput LookupTableFind(TFGraph graph, TensorFlow.TFOutput table_handle, TensorFlow.TFOutput keys, TensorFlow.TFOutput default_value, string operName=null)
		{
			return graph.LookupTableFind(table_handle, keys, default_value, operName);
		}
	}
}
