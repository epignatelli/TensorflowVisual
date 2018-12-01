using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput FixedLengthRecordDataset(this TFGraph graph, TensorFlow.TFOutput filenames, TensorFlow.TFOutput header_bytes, TensorFlow.TFOutput record_bytes, TensorFlow.TFOutput footer_bytes, TensorFlow.TFOutput buffer_size, string operName=null)
		{
			return graph.FixedLengthRecordDataset(filenames, header_bytes, record_bytes, footer_bytes, buffer_size, operName);
		}
	}
}
