using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Cast(this TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFDataType DstT, System.Boolean? Truncate=null, string operName=null)
		{
			return graph.Cast(x, DstT, Truncate, operName);
		}
	}
}
