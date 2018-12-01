using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MutexLock(TFGraph graph, TensorFlow.TFOutput mutex, string operName=null)
		{
			return graph.MutexLock(mutex, operName);
		}
	}
}
