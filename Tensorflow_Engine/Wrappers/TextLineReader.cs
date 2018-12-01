using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TextLineReader(this TFGraph graph, long? skip_header_lines=null, string container=null, string shared_name=null, string operName=null)
		{
			return graph.TextLineReader(skip_header_lines, container, shared_name, operName);
		}
	}
}
