using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation InitializeTableFromTextFileV2(TFGraph graph, TensorFlow.TFOutput table_handle, TensorFlow.TFOutput filename, long key_index, long value_index, long? vocab_size=null, string delimiter=null, string operName=null)
		{
			return graph.InitializeTableFromTextFileV2(table_handle, filename, key_index, value_index, vocab_size, delimiter, operName);
		}
	}
}
