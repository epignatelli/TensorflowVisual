using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ReverseSequence(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput seq_lengths, long seq_dim, long? batch_dim=null, string operName=null)
		{
			return graph.ReverseSequence(input, seq_lengths, seq_dim, batch_dim, operName);
		}
	}
}
