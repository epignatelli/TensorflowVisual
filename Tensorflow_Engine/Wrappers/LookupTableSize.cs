using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput LookupTableSize(this TFGraph graph, TensorFlow.TFOutput table_handle, string operName=null)
		{
			return graph.LookupTableSize(table_handle, operName);
		}
	}
}
