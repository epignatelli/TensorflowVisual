using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation ReaderReset(TFGraph graph, TensorFlow.TFOutput reader_handle, string operName=null)
		{
			return graph.ReaderReset(reader_handle, operName);
		}
	}
}
