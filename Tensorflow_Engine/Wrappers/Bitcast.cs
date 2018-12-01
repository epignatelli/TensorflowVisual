using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Bitcast(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFDataType type, string operName=null)
		{
			return graph.Bitcast(input, type, operName);
		}
	}
}
