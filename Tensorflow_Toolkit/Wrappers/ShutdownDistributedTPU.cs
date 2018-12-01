using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation ShutdownDistributedTPU(TFGraph graph, string operName=null)
		{
			return graph.ShutdownDistributedTPU(operName);
		}
	}
}
