using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DecodePng(this TFGraph graph, TensorFlow.TFOutput contents, long? channels=null, TensorFlow.TFDataType? dtype=null, string operName=null)
		{
			return graph.DecodePng(contents, channels, dtype, operName);
		}
	}
}
