using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ReaderNumRecordsProduced(TFGraph graph, TensorFlow.TFOutput reader_handle, string operName=null)
		{
			return graph.ReaderNumRecordsProduced(reader_handle, operName);
		}
	}
}
