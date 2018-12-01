using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Copy(this TFGraph graph, TensorFlow.TFOutput input, string tensor_name=null, string[] debug_ops_spec=null, string operName=null)
		{
			return graph.Copy(input, tensor_name, debug_ops_spec, operName);
		}
	}
}
