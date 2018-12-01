using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] InfeedDequeueTuple(TFGraph graph, TensorFlow.TFDataType[] dtypes, TensorFlow.TFShape[] shapes, string operName=null)
		{
			return graph.InfeedDequeueTuple(dtypes, shapes, operName);
		}
	}
}
