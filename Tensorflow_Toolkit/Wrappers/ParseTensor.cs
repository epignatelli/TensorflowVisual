using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ParseTensor(TFGraph graph, TensorFlow.TFOutput serialized, TensorFlow.TFDataType out_type, string operName=null)
		{
			return graph.ParseTensor(serialized, out_type, operName);
		}
	}
}
