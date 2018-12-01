using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Real(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFDataType? Tout=null, string operName=null)
		{
			return graph.Real(input, Tout, operName);
		}
	}
}
