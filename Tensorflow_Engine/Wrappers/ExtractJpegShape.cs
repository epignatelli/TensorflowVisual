using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ExtractJpegShape(this TFGraph graph, TensorFlow.TFOutput contents, TensorFlow.TFDataType? output_type=null, string operName=null)
		{
			return graph.ExtractJpegShape(contents, output_type, operName);
		}
	}
}
