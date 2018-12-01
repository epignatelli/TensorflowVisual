using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput OutfeedDequeue(TFGraph graph, TensorFlow.TFDataType dtype, TensorFlow.TFShape shape, long? device_ordinal=null, string operName=null)
		{
			return graph.OutfeedDequeue(dtype, shape, device_ordinal, operName);
		}
	}
}
