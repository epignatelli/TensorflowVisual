using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DecodePng(TFGraph graph, TensorFlow.TFOutput contents, long? channels=null, TensorFlow.TFDataType? dtype=null, string operName=null)
		{
			return graph.DecodePng(contents, channels, dtype, operName);
		}
	}
}
