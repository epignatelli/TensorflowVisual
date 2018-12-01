using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation ReaderRestoreStateV2(this TFGraph graph, TensorFlow.TFOutput reader_handle, TensorFlow.TFOutput state, string operName=null)
		{
			return graph.ReaderRestoreStateV2(reader_handle, state, operName);
		}
	}
}
