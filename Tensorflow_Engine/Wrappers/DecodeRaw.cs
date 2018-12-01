using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DecodeRaw(this TFGraph graph, TensorFlow.TFOutput bytes, TensorFlow.TFDataType out_type, System.Boolean? little_endian=null, string operName=null)
		{
			return graph.DecodeRaw(bytes, out_type, little_endian, operName);
		}
	}
}
