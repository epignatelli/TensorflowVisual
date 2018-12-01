using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput VariableShape(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFDataType? out_type=null, string operName=null)
		{
			return graph.VariableShape(input, out_type, operName);
		}
	}
}
