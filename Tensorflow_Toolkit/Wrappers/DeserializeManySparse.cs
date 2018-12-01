using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> DeserializeManySparse(TFGraph graph, TensorFlow.TFOutput serialized_sparse, TensorFlow.TFDataType dtype, string operName=null)
		{
			return graph.DeserializeManySparse(serialized_sparse, dtype, operName);
		}
	}
}
