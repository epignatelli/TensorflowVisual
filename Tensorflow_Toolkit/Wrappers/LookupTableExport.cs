using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> LookupTableExport(TFGraph graph, TensorFlow.TFOutput table_handle, TensorFlow.TFDataType Tkeys, TensorFlow.TFDataType Tvalues, string operName=null)
		{
			return graph.LookupTableExport(table_handle, Tkeys, Tvalues, operName);
		}
	}
}
