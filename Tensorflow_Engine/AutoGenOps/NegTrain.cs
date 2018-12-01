using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation NegTrain(this TFGraph graph, TensorFlow.TFOutput w_in, TensorFlow.TFOutput w_out, TensorFlow.TFOutput examples, TensorFlow.TFOutput labels, TensorFlow.TFOutput lr, long[] vocab_count, long num_negative_samples, string operName=null)
		{
			return graph.NegTrain(w_in, w_out, examples, labels, lr, vocab_count, num_negative_samples, operName);
		}
	}
}
