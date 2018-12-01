using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput LookupTableSize(TFGraph graph, TensorFlow.TFOutput table_handle, string operName=null)
		{
			return graph.LookupTableSize(table_handle, operName);
		}
	}
}
