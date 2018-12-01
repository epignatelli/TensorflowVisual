using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput OneHot(this TFGraph graph, TensorFlow.TFOutput indices, TensorFlow.TFOutput depth, TensorFlow.TFOutput on_value, TensorFlow.TFOutput off_value, long? axis=null, string operName=null)
		{
			return graph.OneHot(indices, depth, on_value, off_value, axis, operName);
		}
	}
}
