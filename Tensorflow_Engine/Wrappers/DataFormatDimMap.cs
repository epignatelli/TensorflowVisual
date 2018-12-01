using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DataFormatDimMap(this TFGraph graph, TensorFlow.TFOutput x, string src_format=null, string dst_format=null, string operName=null)
		{
			return graph.DataFormatDimMap(x, src_format, dst_format, operName);
		}
	}
}
