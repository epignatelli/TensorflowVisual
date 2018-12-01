using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> CTCLoss(this TFGraph graph, TensorFlow.TFOutput inputs, TensorFlow.TFOutput labels_indices, TensorFlow.TFOutput labels_values, TensorFlow.TFOutput sequence_length, System.Boolean? preprocess_collapse_repeated=null, System.Boolean? ctc_merge_repeated=null, System.Boolean? ignore_longer_outputs_than_inputs=null, string operName=null)
		{
			return graph.CTCLoss(inputs, labels_indices, labels_values, sequence_length, preprocess_collapse_repeated, ctc_merge_repeated, ignore_longer_outputs_than_inputs, operName);
		}
	}
}
