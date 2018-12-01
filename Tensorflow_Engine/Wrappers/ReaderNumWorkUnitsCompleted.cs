using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ReaderNumWorkUnitsCompleted(this TFGraph graph, TensorFlow.TFOutput reader_handle, string operName=null)
		{
			return graph.ReaderNumWorkUnitsCompleted(reader_handle, operName);
		}
	}
}
