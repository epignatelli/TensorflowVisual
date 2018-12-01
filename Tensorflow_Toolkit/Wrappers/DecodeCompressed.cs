using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DecodeCompressed(TFGraph graph, TensorFlow.TFOutput bytes, string compression_type=null, string operName=null)
		{
			return graph.DecodeCompressed(bytes, compression_type, operName);
		}
	}
}
