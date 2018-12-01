using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> ReaderReadUpToV2(this TFGraph graph, TensorFlow.TFOutput reader_handle, TensorFlow.TFOutput queue_handle, TensorFlow.TFOutput num_records, string operName=null)
		{
			return graph.ReaderReadUpToV2(reader_handle, queue_handle, num_records, operName);
		}
	}
}
