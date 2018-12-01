using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> RefMerge(this TFGraph graph, TensorFlow.TFOutput[] inputs, string operName=null)
		{
			return graph.RefMerge(inputs, operName);
		}
	}
}
