using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> ReaderRead(this TFGraph graph, TensorFlow.TFOutput reader_handle, TensorFlow.TFOutput queue_handle, string operName=null)
		{
			return graph.ReaderRead(reader_handle, queue_handle, operName);
		}
	}
}
