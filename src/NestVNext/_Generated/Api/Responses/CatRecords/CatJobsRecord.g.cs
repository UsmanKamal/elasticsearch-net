// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
// Run the following in the root of the repository:
//
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------

using System.Text.Json.Serialization;

#nullable restore
namespace Nest
{
	public class CatJobsRecord
	{
		[JsonInclude, JsonPropertyName("ae")]
		private string? _ae = default;
		[JsonInclude, JsonPropertyName("assignment_explanation")]
		private string? _assignment_explanation = default;
		[JsonInclude, JsonPropertyName("bc")]
		private string? _bc = default;
		[JsonInclude, JsonPropertyName("btea")]
		private string? _btea = default;
		[JsonInclude, JsonPropertyName("bteah")]
		private string? _bteah = default;
		[JsonInclude, JsonPropertyName("btmax")]
		private string? _btmax = default;
		[JsonInclude, JsonPropertyName("btmin")]
		private string? _btmin = default;
		[JsonInclude, JsonPropertyName("btt")]
		private string? _btt = default;
		[JsonInclude, JsonPropertyName("buckets.count")]
		private string? _buckets_count = default;
		[JsonInclude, JsonPropertyName("buckets.time.exp_avg")]
		private string? _buckets_time_exp_avg = default;
		[JsonInclude, JsonPropertyName("buckets.time.exp_avg_hour")]
		private string? _buckets_time_exp_avg_hour = default;
		[JsonInclude, JsonPropertyName("buckets.time.max")]
		private string? _buckets_time_max = default;
		[JsonInclude, JsonPropertyName("buckets.time.min")]
		private string? _buckets_time_min = default;
		[JsonInclude, JsonPropertyName("buckets.time.total")]
		private string? _buckets_time_total = default;
		[JsonInclude, JsonPropertyName("bucketsCount")]
		private string? _bucketsCount = default;
		[JsonInclude, JsonPropertyName("bucketsTimeExpAvg")]
		private string? _bucketsTimeExpAvg = default;
		[JsonInclude, JsonPropertyName("bucketsTimeExpAvgHour")]
		private string? _bucketsTimeExpAvgHour = default;
		[JsonInclude, JsonPropertyName("bucketsTimeMax")]
		private string? _bucketsTimeMax = default;
		[JsonInclude, JsonPropertyName("bucketsTimeMin")]
		private string? _bucketsTimeMin = default;
		[JsonInclude, JsonPropertyName("bucketsTimeTotal")]
		private string? _bucketsTimeTotal = default;
		[JsonInclude, JsonPropertyName("data.buckets")]
		private string? _data_buckets = default;
		[JsonInclude, JsonPropertyName("data.earliest_record")]
		private string? _data_earliest_record = default;
		[JsonInclude, JsonPropertyName("data.empty_buckets")]
		private string? _data_empty_buckets = default;
		[JsonInclude, JsonPropertyName("data.input_bytes")]
		private ByteSize? _data_input_bytes = default;
		[JsonInclude, JsonPropertyName("data.input_fields")]
		private string? _data_input_fields = default;
		[JsonInclude, JsonPropertyName("data.input_records")]
		private string? _data_input_records = default;
		[JsonInclude, JsonPropertyName("data.invalid_dates")]
		private string? _data_invalid_dates = default;
		[JsonInclude, JsonPropertyName("data.last")]
		private string? _data_last = default;
		[JsonInclude, JsonPropertyName("data.last_empty_bucket")]
		private string? _data_last_empty_bucket = default;
		[JsonInclude, JsonPropertyName("data.last_sparse_bucket")]
		private string? _data_last_sparse_bucket = default;
		[JsonInclude, JsonPropertyName("data.latest_record")]
		private string? _data_latest_record = default;
		[JsonInclude, JsonPropertyName("data.missing_fields")]
		private string? _data_missing_fields = default;
		[JsonInclude, JsonPropertyName("data.out_of_order_timestamps")]
		private string? _data_out_of_order_timestamps = default;
		[JsonInclude, JsonPropertyName("data.processed_fields")]
		private string? _data_processed_fields = default;
		[JsonInclude, JsonPropertyName("data.processed_records")]
		private string? _data_processed_records = default;
		[JsonInclude, JsonPropertyName("data.sparse_buckets")]
		private string? _data_sparse_buckets = default;
		[JsonInclude, JsonPropertyName("dataBuckets")]
		private string? _dataBuckets = default;
		[JsonInclude, JsonPropertyName("dataEarliestRecord")]
		private string? _dataEarliestRecord = default;
		[JsonInclude, JsonPropertyName("dataEmptyBuckets")]
		private string? _dataEmptyBuckets = default;
		[JsonInclude, JsonPropertyName("dataInputBytes")]
		private ByteSize? _dataInputBytes = default;
		[JsonInclude, JsonPropertyName("dataInputFields")]
		private string? _dataInputFields = default;
		[JsonInclude, JsonPropertyName("dataInputRecords")]
		private string? _dataInputRecords = default;
		[JsonInclude, JsonPropertyName("dataInvalidDates")]
		private string? _dataInvalidDates = default;
		[JsonInclude, JsonPropertyName("dataLast")]
		private string? _dataLast = default;
		[JsonInclude, JsonPropertyName("dataLastEmptyBucket")]
		private string? _dataLastEmptyBucket = default;
		[JsonInclude, JsonPropertyName("dataLastSparseBucket")]
		private string? _dataLastSparseBucket = default;
		[JsonInclude, JsonPropertyName("dataLatestRecord")]
		private string? _dataLatestRecord = default;
		[JsonInclude, JsonPropertyName("dataMissingFields")]
		private string? _dataMissingFields = default;
		[JsonInclude, JsonPropertyName("dataOutOfOrderTimestamps")]
		private string? _dataOutOfOrderTimestamps = default;
		[JsonInclude, JsonPropertyName("dataProcessedFields")]
		private string? _dataProcessedFields = default;
		[JsonInclude, JsonPropertyName("dataProcessedRecords")]
		private string? _dataProcessedRecords = default;
		[JsonInclude, JsonPropertyName("dataSparseBuckets")]
		private string? _dataSparseBuckets = default;
		[JsonInclude, JsonPropertyName("db")]
		private string? _db = default;
		[JsonInclude, JsonPropertyName("deb")]
		private string? _deb = default;
		[JsonInclude, JsonPropertyName("der")]
		private string? _der = default;
		[JsonInclude, JsonPropertyName("dib")]
		private ByteSize? _dib = default;
		[JsonInclude, JsonPropertyName("did")]
		private string? _did = default;
		[JsonInclude, JsonPropertyName("dif")]
		private string? _dif = default;
		[JsonInclude, JsonPropertyName("dir")]
		private string? _dir = default;
		[JsonInclude, JsonPropertyName("dl")]
		private string? _dl = default;
		[JsonInclude, JsonPropertyName("dleb")]
		private string? _dleb = default;
		[JsonInclude, JsonPropertyName("dlr")]
		private string? _dlr = default;
		[JsonInclude, JsonPropertyName("dlsb")]
		private string? _dlsb = default;
		[JsonInclude, JsonPropertyName("dmf")]
		private string? _dmf = default;
		[JsonInclude, JsonPropertyName("doot")]
		private string? _doot = default;
		[JsonInclude, JsonPropertyName("dpf")]
		private string? _dpf = default;
		[JsonInclude, JsonPropertyName("dpr")]
		private string? _dpr = default;
		[JsonInclude, JsonPropertyName("dsb")]
		private string? _dsb = default;
		[JsonInclude, JsonPropertyName("fmavg")]
		private string? _fmavg = default;
		[JsonInclude, JsonPropertyName("fmmax")]
		private string? _fmmax = default;
		[JsonInclude, JsonPropertyName("fmmin")]
		private string? _fmmin = default;
		[JsonInclude, JsonPropertyName("fmt")]
		private string? _fmt = default;
		[JsonInclude, JsonPropertyName("forecasts.memory.avg")]
		private string? _forecasts_memory_avg = default;
		[JsonInclude, JsonPropertyName("forecasts.memory.max")]
		private string? _forecasts_memory_max = default;
		[JsonInclude, JsonPropertyName("forecasts.memory.min")]
		private string? _forecasts_memory_min = default;
		[JsonInclude, JsonPropertyName("forecasts.memory.total")]
		private string? _forecasts_memory_total = default;
		[JsonInclude, JsonPropertyName("forecasts.records.avg")]
		private string? _forecasts_records_avg = default;
		[JsonInclude, JsonPropertyName("forecasts.records.max")]
		private string? _forecasts_records_max = default;
		[JsonInclude, JsonPropertyName("forecasts.records.min")]
		private string? _forecasts_records_min = default;
		[JsonInclude, JsonPropertyName("forecasts.records.total")]
		private string? _forecasts_records_total = default;
		[JsonInclude, JsonPropertyName("forecasts.time.avg")]
		private string? _forecasts_time_avg = default;
		[JsonInclude, JsonPropertyName("forecasts.time.max")]
		private string? _forecasts_time_max = default;
		[JsonInclude, JsonPropertyName("forecasts.time.min")]
		private string? _forecasts_time_min = default;
		[JsonInclude, JsonPropertyName("forecasts.time.total")]
		private string? _forecasts_time_total = default;
		[JsonInclude, JsonPropertyName("forecasts.total")]
		private string? _forecasts_total = default;
		[JsonInclude, JsonPropertyName("forecastsMemoryAvg")]
		private string? _forecastsMemoryAvg = default;
		[JsonInclude, JsonPropertyName("forecastsMemoryMax")]
		private string? _forecastsMemoryMax = default;
		[JsonInclude, JsonPropertyName("forecastsMemoryMin")]
		private string? _forecastsMemoryMin = default;
		[JsonInclude, JsonPropertyName("forecastsMemoryTotal")]
		private string? _forecastsMemoryTotal = default;
		[JsonInclude, JsonPropertyName("forecastsRecordsAvg")]
		private string? _forecastsRecordsAvg = default;
		[JsonInclude, JsonPropertyName("forecastsRecordsMax")]
		private string? _forecastsRecordsMax = default;
		[JsonInclude, JsonPropertyName("forecastsRecordsMin")]
		private string? _forecastsRecordsMin = default;
		[JsonInclude, JsonPropertyName("forecastsRecordsTotal")]
		private string? _forecastsRecordsTotal = default;
		[JsonInclude, JsonPropertyName("forecastsTimeAvg")]
		private string? _forecastsTimeAvg = default;
		[JsonInclude, JsonPropertyName("forecastsTimeMax")]
		private string? _forecastsTimeMax = default;
		[JsonInclude, JsonPropertyName("forecastsTimeMin")]
		private string? _forecastsTimeMin = default;
		[JsonInclude, JsonPropertyName("forecastsTimeTotal")]
		private string? _forecastsTimeTotal = default;
		[JsonInclude, JsonPropertyName("forecastsTotal")]
		private string? _forecastsTotal = default;
		[JsonInclude, JsonPropertyName("fravg")]
		private string? _fravg = default;
		[JsonInclude, JsonPropertyName("frmax")]
		private string? _frmax = default;
		[JsonInclude, JsonPropertyName("frmin")]
		private string? _frmin = default;
		[JsonInclude, JsonPropertyName("frt")]
		private string? _frt = default;
		[JsonInclude, JsonPropertyName("ft")]
		private string? _ft = default;
		[JsonInclude, JsonPropertyName("ftavg")]
		private string? _ftavg = default;
		[JsonInclude, JsonPropertyName("ftmax")]
		private string? _ftmax = default;
		[JsonInclude, JsonPropertyName("ftmin")]
		private string? _ftmin = default;
		[JsonInclude, JsonPropertyName("ftt")]
		private string? _ftt = default;
		[JsonInclude, JsonPropertyName("mb")]
		private ByteSize? _mb = default;
		[JsonInclude, JsonPropertyName("mbaf")]
		private string? _mbaf = default;
		[JsonInclude, JsonPropertyName("mbe")]
		private ByteSize? _mbe = default;
		[JsonInclude, JsonPropertyName("mbf")]
		private string? _mbf = default;
		[JsonInclude, JsonPropertyName("mcdc")]
		private string? _mcdc = default;
		[JsonInclude, JsonPropertyName("mcs")]
		private ModelCategorizationStatus? _mcs = default;
		[JsonInclude, JsonPropertyName("mdcc")]
		private string? _mdcc = default;
		[JsonInclude, JsonPropertyName("mfcc")]
		private string? _mfcc = default;
		[JsonInclude, JsonPropertyName("mlt")]
		private string? _mlt = default;
		[JsonInclude, JsonPropertyName("mml")]
		private string? _mml = default;
		[JsonInclude, JsonPropertyName("mms")]
		private ModelMemoryStatus? _mms = default;
		[JsonInclude, JsonPropertyName("model.bucket_allocation_failures")]
		private string? _model_bucket_allocation_failures = default;
		[JsonInclude, JsonPropertyName("model.by_fields")]
		private string? _model_by_fields = default;
		[JsonInclude, JsonPropertyName("model.bytes")]
		private ByteSize? _model_bytes = default;
		[JsonInclude, JsonPropertyName("model.bytes_exceeded")]
		private ByteSize? _model_bytes_exceeded = default;
		[JsonInclude, JsonPropertyName("model.categorization_status")]
		private ModelCategorizationStatus? _model_categorization_status = default;
		[JsonInclude, JsonPropertyName("model.categorized_doc_count")]
		private string? _model_categorized_doc_count = default;
		[JsonInclude, JsonPropertyName("model.dead_category_count")]
		private string? _model_dead_category_count = default;
		[JsonInclude, JsonPropertyName("model.failed_category_count")]
		private string? _model_failed_category_count = default;
		[JsonInclude, JsonPropertyName("model.frequent_category_count")]
		private string? _model_frequent_category_count = default;
		[JsonInclude, JsonPropertyName("model.log_time")]
		private string? _model_log_time = default;
		[JsonInclude, JsonPropertyName("model.memory_limit")]
		private string? _model_memory_limit = default;
		[JsonInclude, JsonPropertyName("model.memory_status")]
		private ModelMemoryStatus? _model_memory_status = default;
		[JsonInclude, JsonPropertyName("model.over_fields")]
		private string? _model_over_fields = default;
		[JsonInclude, JsonPropertyName("model.partition_fields")]
		private string? _model_partition_fields = default;
		[JsonInclude, JsonPropertyName("model.rare_category_count")]
		private string? _model_rare_category_count = default;
		[JsonInclude, JsonPropertyName("model.timestamp")]
		private string? _model_timestamp = default;
		[JsonInclude, JsonPropertyName("model.total_category_count")]
		private string? _model_total_category_count = default;
		[JsonInclude, JsonPropertyName("modelBucketAllocationFailures")]
		private string? _modelBucketAllocationFailures = default;
		[JsonInclude, JsonPropertyName("modelByFields")]
		private string? _modelByFields = default;
		[JsonInclude, JsonPropertyName("modelBytes")]
		private ByteSize? _modelBytes = default;
		[JsonInclude, JsonPropertyName("modelBytesExceeded")]
		private ByteSize? _modelBytesExceeded = default;
		[JsonInclude, JsonPropertyName("modelCategorizationStatus")]
		private ModelCategorizationStatus? _modelCategorizationStatus = default;
		[JsonInclude, JsonPropertyName("modelCategorizedDocCount")]
		private string? _modelCategorizedDocCount = default;
		[JsonInclude, JsonPropertyName("modelDeadCategoryCount")]
		private string? _modelDeadCategoryCount = default;
		[JsonInclude, JsonPropertyName("modelFailedCategoryCount")]
		private string? _modelFailedCategoryCount = default;
		[JsonInclude, JsonPropertyName("modelFrequentCategoryCount")]
		private string? _modelFrequentCategoryCount = default;
		[JsonInclude, JsonPropertyName("modelLogTime")]
		private string? _modelLogTime = default;
		[JsonInclude, JsonPropertyName("modelMemoryLimit")]
		private string? _modelMemoryLimit = default;
		[JsonInclude, JsonPropertyName("modelMemoryStatus")]
		private ModelMemoryStatus? _modelMemoryStatus = default;
		[JsonInclude, JsonPropertyName("modelOverFields")]
		private string? _modelOverFields = default;
		[JsonInclude, JsonPropertyName("modelPartitionFields")]
		private string? _modelPartitionFields = default;
		[JsonInclude, JsonPropertyName("modelRareCategoryCount")]
		private string? _modelRareCategoryCount = default;
		[JsonInclude, JsonPropertyName("modelTimestamp")]
		private string? _modelTimestamp = default;
		[JsonInclude, JsonPropertyName("modelTotalCategoryCount")]
		private string? _modelTotalCategoryCount = default;
		[JsonInclude, JsonPropertyName("mof")]
		private string? _mof = default;
		[JsonInclude, JsonPropertyName("mpf")]
		private string? _mpf = default;
		[JsonInclude, JsonPropertyName("mrcc")]
		private string? _mrcc = default;
		[JsonInclude, JsonPropertyName("mt")]
		private string? _mt = default;
		[JsonInclude, JsonPropertyName("mtcc")]
		private string? _mtcc = default;
		[JsonInclude, JsonPropertyName("na")]
		private string? _na = default;
		[JsonInclude, JsonPropertyName("ne")]
		private NodeId? _ne = default;
		[JsonInclude, JsonPropertyName("ni")]
		private NodeId? _ni = default;
		[JsonInclude, JsonPropertyName("nn")]
		private string? _nn = default;
		[JsonInclude, JsonPropertyName("node.address")]
		private string? _node_address = default;
		[JsonInclude, JsonPropertyName("node.ephemeral_id")]
		private NodeId? _node_ephemeral_id = default;
		[JsonInclude, JsonPropertyName("node.id")]
		private NodeId? _node_id = default;
		[JsonInclude, JsonPropertyName("node.name")]
		private string? _node_name = default;
		[JsonInclude, JsonPropertyName("nodeAddress")]
		private string? _nodeAddress = default;
		[JsonInclude, JsonPropertyName("nodeEphemeralId")]
		private NodeId? _nodeEphemeralId = default;
		[JsonInclude, JsonPropertyName("nodeId")]
		private NodeId? _nodeId = default;
		[JsonInclude, JsonPropertyName("nodeName")]
		private string? _nodeName = default;
		[JsonInclude, JsonPropertyName("opened_time")]
		private string? _opened_time = default;
		[JsonInclude, JsonPropertyName("ot")]
		private string? _ot = default;
		[JsonInclude, JsonPropertyName("s")]
		private JobState? _s = default;
		[JsonInclude, JsonPropertyName("state")]
		private JobState? _state = default;
		public string? AssignmentExplanation => _ae ?? _assignment_explanation;
		public string? BucketsCount => _buckets_count ?? _bc ?? _bucketsCount;
		public string? BucketsTimeExpAvg => _buckets_time_exp_avg ?? _btea ?? _bucketsTimeExpAvg;
		public string? BucketsTimeExpAvgHour => _buckets_time_exp_avg_hour ?? _bteah ?? _bucketsTimeExpAvgHour;
		public string? BucketsTimeMax => _buckets_time_max ?? _btmax ?? _bucketsTimeMax;
		public string? BucketsTimeMin => _buckets_time_min ?? _btmin ?? _bucketsTimeMin;
		public string? BucketsTimeTotal => _buckets_time_total ?? _btt ?? _bucketsTimeTotal;
		public string? DataBuckets => _data_buckets ?? _db ?? _dataBuckets;
		public string? DataEarliestRecord => _data_earliest_record ?? _der ?? _dataEarliestRecord;
		public string? DataEmptyBuckets => _data_empty_buckets ?? _deb ?? _dataEmptyBuckets;
		public ByteSize? DataInputBytes => _data_input_bytes ?? _dib ?? _dataInputBytes;
		public string? DataInputFields => _data_input_fields ?? _dif ?? _dataInputFields;
		public string? DataInputRecords => _data_input_records ?? _dir ?? _dataInputRecords;
		public string? DataInvalidDates => _data_invalid_dates ?? _did ?? _dataInvalidDates;
		public string? DataLast => _data_last ?? _dl ?? _dataLast;
		public string? DataLastEmptyBucket => _data_last_empty_bucket ?? _dleb ?? _dataLastEmptyBucket;
		public string? DataLastSparseBucket => _data_last_sparse_bucket ?? _dlsb ?? _dataLastSparseBucket;
		public string? DataLatestRecord => _data_latest_record ?? _dlr ?? _dataLatestRecord;
		public string? DataMissingFields => _data_missing_fields ?? _dmf ?? _dataMissingFields;
		public string? DataOutOfOrderTimestamps => _data_out_of_order_timestamps ?? _doot ?? _dataOutOfOrderTimestamps;
		public string? DataProcessedFields => _data_processed_fields ?? _dpf ?? _dataProcessedFields;
		public string? DataProcessedRecords => _data_processed_records ?? _dpr ?? _dataProcessedRecords;
		public string? DataSparseBuckets => _data_sparse_buckets ?? _dsb ?? _dataSparseBuckets;
		public string? ForecastsMemoryAvg => _forecasts_memory_avg ?? _fmavg ?? _forecastsMemoryAvg;
		public string? ForecastsMemoryMax => _forecasts_memory_max ?? _fmmax ?? _forecastsMemoryMax;
		public string? ForecastsMemoryMin => _forecasts_memory_min ?? _fmmin ?? _forecastsMemoryMin;
		public string? ForecastsMemoryTotal => _forecasts_memory_total ?? _fmt ?? _forecastsMemoryTotal;
		public string? ForecastsRecordsAvg => _forecasts_records_avg ?? _fravg ?? _forecastsRecordsAvg;
		public string? ForecastsRecordsMax => _forecasts_records_max ?? _frmax ?? _forecastsRecordsMax;
		public string? ForecastsRecordsMin => _forecasts_records_min ?? _frmin ?? _forecastsRecordsMin;
		public string? ForecastsRecordsTotal => _forecasts_records_total ?? _frt ?? _forecastsRecordsTotal;
		public string? ForecastsTimeAvg => _forecasts_time_avg ?? _ftavg ?? _forecastsTimeAvg;
		public string? ForecastsTimeMax => _forecasts_time_max ?? _ftmax ?? _forecastsTimeMax;
		public string? ForecastsTimeMin => _forecasts_time_min ?? _ftmin ?? _forecastsTimeMin;
		public string? ForecastsTimeTotal => _forecasts_time_total ?? _ftt ?? _forecastsTimeTotal;
		public string? ForecastsTotal => _forecasts_total ?? _ft ?? _forecastsTotal;
		[JsonPropertyName("id")]
		public Id Id
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		public string? ModelBucketAllocationFailures => _model_bucket_allocation_failures ?? _mbaf ?? _modelBucketAllocationFailures;
		public string? ModelByFields => _model_by_fields ?? _mbf ?? _modelByFields;
		public ByteSize? ModelBytes => _model_bytes ?? _mb ?? _modelBytes;
		public ByteSize? ModelBytesExceeded => _model_bytes_exceeded ?? _mbe ?? _modelBytesExceeded;
		public ModelCategorizationStatus? ModelCategorizationStatus => _model_categorization_status ?? _mcs ?? _modelCategorizationStatus;
		public string? ModelCategorizedDocCount => _model_categorized_doc_count ?? _mcdc ?? _modelCategorizedDocCount;
		public string? ModelDeadCategoryCount => _model_dead_category_count ?? _mdcc ?? _modelDeadCategoryCount;
		public string? ModelFailedCategoryCount => _model_failed_category_count ?? _mfcc ?? _modelFailedCategoryCount;
		public string? ModelFrequentCategoryCount => _modelFrequentCategoryCount ?? _model_frequent_category_count;
		public string? ModelLogTime => _model_log_time ?? _mlt ?? _modelLogTime;
		public string? ModelMemoryLimit => _model_memory_limit ?? _mml ?? _modelMemoryLimit;
		public ModelMemoryStatus? ModelMemoryStatus => _model_memory_status ?? _mms ?? _modelMemoryStatus;
		public string? ModelOverFields => _model_over_fields ?? _mof ?? _modelOverFields;
		public string? ModelPartitionFields => _model_partition_fields ?? _mpf ?? _modelPartitionFields;
		public string? ModelRareCategoryCount => _model_rare_category_count ?? _mrcc ?? _modelRareCategoryCount;
		public string? ModelTimestamp => _model_timestamp ?? _mt ?? _modelTimestamp;
		public string? ModelTotalCategoryCount => _model_total_category_count ?? _mtcc ?? _modelTotalCategoryCount;
		public string? NodeAddress => _node_address ?? _na ?? _nodeAddress;
		public NodeId? NodeEphemeralId => _node_ephemeral_id ?? _ne ?? _nodeEphemeralId;
		public NodeId? NodeId => _node_id ?? _ni ?? _nodeId;
		public string? NodeName => _node_name ?? _nn ?? _nodeName;
		public string? OpenedTime => _ot ?? _opened_time;
		public JobState? State => _s ?? _state;
	}
}