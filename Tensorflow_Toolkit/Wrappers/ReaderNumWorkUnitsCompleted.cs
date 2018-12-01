using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ReaderNumWorkUnitsCompleted(TFGraph graph, TensorFlow.TFOutput reader_handle, string operName=null)
		{
			return graph.ReaderNumWorkUnitsCompleted(reader_handle, operName);
		}
	}
}
