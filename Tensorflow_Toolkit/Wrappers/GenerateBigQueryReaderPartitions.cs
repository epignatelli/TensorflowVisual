using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput GenerateBigQueryReaderPartitions(TFGraph graph, string project_id, string dataset_id, string table_id, string[] columns, long timestamp_millis, long num_partitions, string test_end_point=null, string operName=null)
		{
			return graph.GenerateBigQueryReaderPartitions(project_id, dataset_id, table_id, columns, timestamp_millis, num_partitions, test_end_point, operName);
		}
	}
}
