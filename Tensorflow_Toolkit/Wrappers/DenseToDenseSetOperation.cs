using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> DenseToDenseSetOperation(TFGraph graph, TensorFlow.TFOutput set1, TensorFlow.TFOutput set2, string set_operation, System.Boolean? validate_indices=null, string operName=null)
		{
			return graph.DenseToDenseSetOperation(set1, set2, set_operation, validate_indices, operName);
		}
	}
}
