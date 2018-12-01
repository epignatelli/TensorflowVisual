using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput WholeFileReaderV2(TFGraph graph, string container=null, string shared_name=null, string operName=null)
		{
			return graph.WholeFileReaderV2(container, shared_name, operName);
		}
	}
}
