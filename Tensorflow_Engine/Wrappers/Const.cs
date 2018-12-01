using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Const(this TFGraph graph, TensorFlow.TFTensor value, TensorFlow.TFDataType dtype, string operName=null)
		{
			return graph.Const(value, dtype, operName);
		}
	}
}
