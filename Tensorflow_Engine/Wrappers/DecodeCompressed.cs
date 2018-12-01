using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DecodeCompressed(this TFGraph graph, TensorFlow.TFOutput bytes, string compression_type=null, string operName=null)
		{
			return graph.DecodeCompressed(bytes, compression_type, operName);
		}
	}
}
