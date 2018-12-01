using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput VarHandleOp(this TFGraph graph, TensorFlow.TFDataType dtype, TensorFlow.TFShape shape, string container=null, string shared_name=null, string operName=null)
		{
			return graph.VarHandleOp(dtype, shape, container, shared_name, operName);
		}
	}
}
