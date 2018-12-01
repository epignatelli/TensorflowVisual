using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> LookupTableExportV2(this TFGraph graph, TensorFlow.TFOutput table_handle, TensorFlow.TFDataType Tkeys, TensorFlow.TFDataType Tvalues, string operName=null)
		{
			return graph.LookupTableExportV2(table_handle, Tkeys, Tvalues, operName);
		}
	}
}
