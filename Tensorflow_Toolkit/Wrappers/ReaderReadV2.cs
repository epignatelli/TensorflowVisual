using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> ReaderReadV2(TFGraph graph, TensorFlow.TFOutput reader_handle, TensorFlow.TFOutput queue_handle, string operName=null)
		{
			return graph.ReaderReadV2(reader_handle, queue_handle, operName);
		}
	}
}
