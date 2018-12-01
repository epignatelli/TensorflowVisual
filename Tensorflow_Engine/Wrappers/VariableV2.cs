using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput VariableV2(this TFGraph graph, TensorFlow.TFShape shape, TensorFlow.TFDataType dtype, string container=null, string shared_name=null, string operName=null)
		{
			return graph.VariableV2(shape, dtype, container, shared_name, operName);
		}
	}
}
