using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation MergeV2Checkpoints(TFGraph graph, TensorFlow.TFOutput checkpoint_prefixes, TensorFlow.TFOutput destination_prefix, System.Boolean? delete_old_dirs=null, string operName=null)
		{
			return graph.MergeV2Checkpoints(checkpoint_prefixes, destination_prefix, delete_old_dirs, operName);
		}
	}
}
