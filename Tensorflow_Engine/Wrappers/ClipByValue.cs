using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ClipByValue(this TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput clip_value_min, TensorFlow.TFOutput clip_value_max, string operName=null)
		{
			return graph.ClipByValue(x, clip_value_min, clip_value_max, operName);
		}
	}
}
