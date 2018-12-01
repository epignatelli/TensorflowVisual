using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TFRecordReaderV2(TFGraph graph, string container=null, string shared_name=null, string compression_type=null, string operName=null)
		{
			return graph.TFRecordReaderV2(container, shared_name, compression_type, operName);
		}
	}
}
