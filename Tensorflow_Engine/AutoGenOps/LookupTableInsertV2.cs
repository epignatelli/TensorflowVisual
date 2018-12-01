using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation LookupTableInsertV2(this TFGraph graph, TensorFlow.TFOutput table_handle, TensorFlow.TFOutput keys, TensorFlow.TFOutput values, string operName=null)
		{
			return graph.LookupTableInsertV2(table_handle, keys, values, operName);
		}
	}
}
