using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ReaderNumWorkUnitsCompletedV2(TFGraph graph, TensorFlow.TFOutput reader_handle, string operName=null)
		{
			return graph.ReaderNumWorkUnitsCompletedV2(reader_handle, operName);
		}
	}
}