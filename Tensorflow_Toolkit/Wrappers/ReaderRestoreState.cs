using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation ReaderRestoreState(TFGraph graph, TensorFlow.TFOutput reader_handle, TensorFlow.TFOutput state, string operName=null)
		{
			return graph.ReaderRestoreState(reader_handle, state, operName);
		}
	}
}
