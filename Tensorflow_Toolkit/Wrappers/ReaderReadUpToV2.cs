using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> ReaderReadUpToV2(TFGraph graph, TensorFlow.TFOutput reader_handle, TensorFlow.TFOutput queue_handle, TensorFlow.TFOutput num_records, string operName=null)
		{
			return graph.ReaderReadUpToV2(reader_handle, queue_handle, num_records, operName);
		}
	}
}
