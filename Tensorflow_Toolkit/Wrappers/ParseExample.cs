using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput[],TensorFlow.TFOutput[],TensorFlow.TFOutput[],TensorFlow.TFOutput[]> ParseExample(TFGraph graph, TensorFlow.TFOutput serialized, TensorFlow.TFOutput names, TensorFlow.TFOutput[] sparse_keys, TensorFlow.TFOutput[] dense_keys, TensorFlow.TFOutput[] dense_defaults, TensorFlow.TFDataType[] sparse_types, TensorFlow.TFShape[] dense_shapes, string operName=null)
		{
			return graph.ParseExample(serialized, names, sparse_keys, dense_keys, dense_defaults, sparse_types, dense_shapes, operName);
		}
	}
}
