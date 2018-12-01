using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput EncodeJpeg(this TFGraph graph, TensorFlow.TFOutput image, string format=null, long? quality=null, System.Boolean? progressive=null, System.Boolean? optimize_size=null, System.Boolean? chroma_downsampling=null, string density_unit=null, long? x_density=null, long? y_density=null, string xmp_metadata=null, string operName=null)
		{
			return graph.EncodeJpeg(image, format, quality, progressive, optimize_size, chroma_downsampling, density_unit, x_density, y_density, xmp_metadata, operName);
		}
	}
}
