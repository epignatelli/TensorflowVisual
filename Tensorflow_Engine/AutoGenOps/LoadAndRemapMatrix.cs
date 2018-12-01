using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput LoadAndRemapMatrix(this TFGraph graph, TensorFlow.TFOutput ckpt_path, TensorFlow.TFOutput old_tensor_name, TensorFlow.TFOutput row_remapping, TensorFlow.TFOutput col_remapping, TensorFlow.TFOutput initializing_values, long num_rows, long num_cols, long? max_rows_in_memory=null, string operName=null)
		{
			return graph.LoadAndRemapMatrix(ckpt_path, old_tensor_name, row_remapping, col_remapping, initializing_values, num_rows, num_cols, max_rows_in_memory, operName);
		}
	}
}
