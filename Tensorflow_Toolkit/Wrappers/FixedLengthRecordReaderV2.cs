using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput FixedLengthRecordReaderV2(TFGraph graph, long record_bytes, long? header_bytes=null, long? footer_bytes=null, long? hop_bytes=null, string container=null, string shared_name=null, string encoding=null, string operName=null)
		{
			return graph.FixedLengthRecordReaderV2(record_bytes, header_bytes, footer_bytes, hop_bytes, container, shared_name, encoding, operName);
		}
	}
}