using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ComplexAbs(TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFDataType? Tout=null, string operName=null)
		{
			return graph.ComplexAbs(x, Tout, operName);
		}
	}
}
