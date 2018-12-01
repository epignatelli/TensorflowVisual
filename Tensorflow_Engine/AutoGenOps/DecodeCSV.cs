using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] DecodeCSV(this TFGraph graph, TensorFlow.TFOutput records, TensorFlow.TFOutput[] record_defaults, string field_delim=null, System.Boolean? use_quote_delim=null, string na_value=null, long[] select_cols=null, string operName=null)
		{
			return graph.DecodeCSV(records, record_defaults, field_delim, use_quote_delim, na_value, select_cols, operName);
		}
	}
}
