using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput EncodePng(this TFGraph graph, TensorFlow.TFOutput image, long? compression=null, string operName=null)
		{
			return graph.EncodePng(image, compression, operName);
		}
	}
}
