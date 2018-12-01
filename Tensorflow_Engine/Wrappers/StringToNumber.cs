using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput StringToNumber(this TFGraph graph, TensorFlow.TFOutput string_tensor, TensorFlow.TFDataType? out_type=null, string operName=null)
		{
			return graph.StringToNumber(string_tensor, out_type, operName);
		}
	}
}
