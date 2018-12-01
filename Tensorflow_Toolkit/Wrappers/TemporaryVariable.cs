using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TemporaryVariable(TFGraph graph, TensorFlow.TFShape shape, TensorFlow.TFDataType dtype, string var_name=null, string operName=null)
		{
			return graph.TemporaryVariable(shape, dtype, var_name, operName);
		}
	}
}
