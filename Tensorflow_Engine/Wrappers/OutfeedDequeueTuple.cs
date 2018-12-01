using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] OutfeedDequeueTuple(this TFGraph graph, TensorFlow.TFDataType[] dtypes, TensorFlow.TFShape[] shapes, long? device_ordinal=null, string operName=null)
		{
			return graph.OutfeedDequeueTuple(dtypes, shapes, device_ordinal, operName);
		}
	}
}
