using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Bitcast(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFDataType type, string operName=null)
		{
			return graph.Bitcast(input, type, operName);
		}
	}
}
