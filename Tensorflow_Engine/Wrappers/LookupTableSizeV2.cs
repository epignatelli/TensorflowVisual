using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput LookupTableSizeV2(this TFGraph graph, TensorFlow.TFOutput table_handle, string operName=null)
		{
			return graph.LookupTableSizeV2(table_handle, operName);
		}
	}
}
