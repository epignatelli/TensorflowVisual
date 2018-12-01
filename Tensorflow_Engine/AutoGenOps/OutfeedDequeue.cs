using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput OutfeedDequeue(this TFGraph graph, TensorFlow.TFDataType dtype, TensorFlow.TFShape shape, long? device_ordinal=null, string operName=null)
		{
			return graph.OutfeedDequeue(dtype, shape, device_ordinal, operName);
		}
	}
}
