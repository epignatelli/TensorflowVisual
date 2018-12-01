using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TemporaryVariable(this TFGraph graph, TensorFlow.TFShape shape, TensorFlow.TFDataType dtype, string var_name=null, string operName=null)
		{
			return graph.TemporaryVariable(shape, dtype, var_name, operName);
		}
	}
}
