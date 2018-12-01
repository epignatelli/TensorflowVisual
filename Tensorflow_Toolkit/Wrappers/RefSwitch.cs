using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> RefSwitch(TFGraph graph, TensorFlow.TFOutput data, TensorFlow.TFOutput pred, string operName=null)
		{
			return graph.RefSwitch(data, pred, operName);
		}
	}
}
