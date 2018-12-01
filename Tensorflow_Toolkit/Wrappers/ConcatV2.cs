using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ConcatV2(TFGraph graph, TensorFlow.TFOutput[] values, TensorFlow.TFOutput axis, string operName=null)
		{
			return graph.ConcatV2(values, axis, operName);
		}
	}
}
