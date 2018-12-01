using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput FixedLengthRecordReader(this TFGraph graph, long record_bytes, long? header_bytes=null, long? footer_bytes=null, long? hop_bytes=null, string container=null, string shared_name=null, string operName=null)
		{
			return graph.FixedLengthRecordReader(record_bytes, header_bytes, footer_bytes, hop_bytes, container, shared_name, operName);
		}
	}
}
