using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput LookupTableSizeV2(TFGraph graph, TensorFlow.TFOutput table_handle, string operName=null)
		{
			return graph.LookupTableSizeV2(table_handle, operName);
		}
	}
}
