using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput BigQueryReader(this TFGraph graph, string project_id, string dataset_id, string table_id, string[] columns, long timestamp_millis, string container=null, string shared_name=null, string test_end_point=null, string operName=null)
		{
			return graph.BigQueryReader(project_id, dataset_id, table_id, columns, timestamp_millis, container, shared_name, test_end_point, operName);
		}
	}
}
