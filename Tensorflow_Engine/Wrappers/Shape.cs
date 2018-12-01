using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Shape(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFDataType? out_type=null, string operName=null)
		{
			return graph.Shape(input, out_type, operName);
		}
	}
}
