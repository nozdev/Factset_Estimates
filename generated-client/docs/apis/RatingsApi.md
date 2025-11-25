# FactsetEstimatesClient.Api.RatingsApi

All URIs are relative to *https://api.factset.com/content*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetConsensusRatings**](RatingsApi.md#getconsensusratings) | **GET** /factset-estimates/v2/consensus-ratings | Ratings consensus estimates to fetch Buy, overWeight, Hold, underWeight, and Sell. |
| [**GetConsensusRatingsForList**](RatingsApi.md#getconsensusratingsforlist) | **POST** /factset-estimates/v2/consensus-ratings | Ratings consensus estimates to fetch Buy, overWeight, Hold, underWeight, and Sell. |
| [**GetDetailRatings**](RatingsApi.md#getdetailratings) | **GET** /factset-estimates/v2/detail-ratings | Broker Detail estimates to fetch Buy, overWeight, Hold, underWeight, and Sell. |
| [**GetDetailRatingsForList**](RatingsApi.md#getdetailratingsforlist) | **POST** /factset-estimates/v2/detail-ratings | Broker Detail estimates to fetch Buy, overWeight, Hold, underWeight, and Sell. |

<a id="getconsensusratings"></a>
# **GetConsensusRatings**
> ConsensusRatingsResponse GetConsensusRatings (List<string> ids, DateOnly startDate = null, DateOnly endDate = null, string frequency = null)

Ratings consensus estimates to fetch Buy, overWeight, Hold, underWeight, and Sell.

Returns ratings from the FactSet Estimates database for current and historical for an individual security using rolling fiscal dates as of a specific date. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | [**List&lt;string&gt;**](string.md) | Security or Entity identifiers. Accepted inputs include FactSet Identifiers, tickers, CUSIP, and SEDOL. &lt;p&gt;&lt;b&gt;Performance Note:&lt;/b&gt; Requests that increase the number of metrics or request long historical data may trigger the 30-second service timeout threshold. To ensure system stability and performance, please keep requests lightweight.&lt;/p&gt; &lt;p&gt;If requesting long historical data, limit the history to &lt;b&gt;10 years per metric per ID&lt;/b&gt;.&lt;/p&gt;  |  |
| **startDate** | **DateOnly** | Start date for point in time of estimates expressed in YYYY-MM-DD format. | [optional]  |
| **endDate** | **DateOnly** | End date for point in time of estimates expressed in YYYY-MM-DD format. | [optional]  |
| **frequency** | **string** | Controls the frequency of the data returned.   * **D** &#x3D; Daily   * **W** &#x3D; Weekly, based on the last day of the week of the start date.   * **AM** &#x3D; Monthly, based on the start date (e.g., if the start date is June 16, data is displayed for June 16, May 16, April 16 etc.).         * **AQ** &#x3D; Quarterly, based on the start date.   * **AY** &#x3D; Actual Annual, based on the start date.   | [optional] [default to AM] |

### Return type

[**ConsensusRatingsResponse**](ConsensusRatingsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Estimate data items |  -  |
| **400** | Bad Request. This can occur for several reasons. Please review the \&quot;message\&quot; for more details. |  -  |
| **401** | Unauthenticated USERNAME-SERIAL. Ensure you are logged in and have successfully generated an API KEY for the IP range you are connecting from. For more help, select the **Report Issue** in the top right corner of this Developer Portal specification card and choose Connectivity 401 or 403 Responses. |  -  |
| **403** | The USERNAME-SERIAL attempted to request the endpoint is not authorized to access. The request was a legal request, but the server is refusing to respond. Please reach out to FactSet Account Team for assistance with authorization. |  -  |
| **415** | Unsupported Media Type. This error may be returned when the caller sends a resource in a format that is not accepted by the server. This can be fixed by ensuring that Content-Type header is set to the correct value. In this instance, \&quot;application/json\&quot; would be the appropriate value. |  -  |
| **500** | Internal Server Error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getconsensusratingsforlist"></a>
# **GetConsensusRatingsForList**
> ConsensusRatingsResponse GetConsensusRatingsForList (ConsensusRatingsRequest consensusRatingsRequest)

Ratings consensus estimates to fetch Buy, overWeight, Hold, underWeight, and Sell.

Returns ratings from the FactSet Estimates database for current and historical for an individual security using rolling fiscal dates as of a specific date. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **consensusRatingsRequest** | [**ConsensusRatingsRequest**](ConsensusRatingsRequest.md) | Request object for Estimate Data Items. |  |

### Return type

[**ConsensusRatingsResponse**](ConsensusRatingsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Estimate data items |  -  |
| **400** | Bad Request. This can occur for several reasons. Please review the \&quot;message\&quot; for more details. |  -  |
| **401** | Unauthenticated USERNAME-SERIAL. Ensure you are logged in and have successfully generated an API KEY for the IP range you are connecting from. For more help, select the **Report Issue** in the top right corner of this Developer Portal specification card and choose Connectivity 401 or 403 Responses. |  -  |
| **403** | The USERNAME-SERIAL attempted to request the endpoint is not authorized to access. The request was a legal request, but the server is refusing to respond. Please reach out to FactSet Account Team for assistance with authorization. |  -  |
| **415** | Unsupported Media Type. This error may be returned when the caller sends a resource in a format that is not accepted by the server. This can be fixed by ensuring that Content-Type header is set to the correct value. In this instance, \&quot;application/json\&quot; would be the appropriate value. |  -  |
| **500** | Internal Server Error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getdetailratings"></a>
# **GetDetailRatings**
> DetailRatingsResponse GetDetailRatings (List<string> ids, DateOnly startDate = null, DateOnly endDate = null, bool includeAll = null)

Broker Detail estimates to fetch Buy, overWeight, Hold, underWeight, and Sell.

Retrieves the Broker Level ratings for the requested Id and date range. Ratings include Buy, Hold, Sell, overWeight, and underWeight. <p>The `startDate` and `endDate` parameters controls the range of perspective dates. By default, the service will return the range of estimateDates within the latest company's reporting period. As you expand the date range, additional full historical reporting periods and all ratings estimateDates per broker will be returned.</p> 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | [**List&lt;string&gt;**](string.md) | Security or Entity identifiers. Accepted inputs include FactSet Identifiers, tickers, CUSIP, and SEDOL. &lt;p&gt;&lt;b&gt;Performance Note:&lt;/b&gt; Requests that increase the number of metrics or request long historical data may trigger the 30-second service timeout threshold. To ensure system stability and performance, please keep requests lightweight.&lt;/p&gt; &lt;p&gt;If requesting long historical data, limit the history to &lt;b&gt;10 years per metric per ID&lt;/b&gt;.&lt;/p&gt;  |  |
| **startDate** | **DateOnly** | Start date for point in time of estimates expressed in YYYY-MM-DD format. | [optional]  |
| **endDate** | **DateOnly** | End date for point in time of estimates expressed in YYYY-MM-DD format. | [optional]  |
| **includeAll** | **bool** | Include All filter is used to identify included and excluded broker details from the consensus   By default the service would return only the brokers included in the consensus-   * **TRUE** &#x3D; Returns all the brokers included and excluded in the consensus   * **FALSE** &#x3D; Returns only the broker details included in the consensus     | [optional] [default to false] |

### Return type

[**DetailRatingsResponse**](DetailRatingsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Estimate Ratings data items |  -  |
| **400** | Bad Request. This can occur for several reasons. Please review the \&quot;message\&quot; for more details. |  -  |
| **401** | Unauthenticated USERNAME-SERIAL. Ensure you are logged in and have successfully generated an API KEY for the IP range you are connecting from. For more help, select the **Report Issue** in the top right corner of this Developer Portal specification card and choose Connectivity 401 or 403 Responses. |  -  |
| **403** | The USERNAME-SERIAL attempted to request the endpoint is not authorized to access. The request was a legal request, but the server is refusing to respond. Please reach out to FactSet Account Team for assistance with authorization. |  -  |
| **415** | Unsupported Media Type. This error may be returned when the caller sends a resource in a format that is not accepted by the server. This can be fixed by ensuring that Content-Type header is set to the correct value. In this instance, \&quot;application/json\&quot; would be the appropriate value. |  -  |
| **500** | Internal Server Error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getdetailratingsforlist"></a>
# **GetDetailRatingsForList**
> DetailRatingsResponse GetDetailRatingsForList (DetailRatingsRequest detailRatingsRequest)

Broker Detail estimates to fetch Buy, overWeight, Hold, underWeight, and Sell.

Retrieves the Broker Level ratings for the requested Id and date range. Ratings include Buy, Hold, Sell, overWeight, and underWeight. <p>The `startDate` and `endDate` parameters controls the range of perspective dates. By default, the service will return the range of estimateDates within the latest company's reporting period. As you expand the date range, additional full historical reporting periods and all ratings estimateDates per broker will be returned.</p> 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **detailRatingsRequest** | [**DetailRatingsRequest**](DetailRatingsRequest.md) | Request object for Detail Reatings Data Items. |  |

### Return type

[**DetailRatingsResponse**](DetailRatingsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Estimate Detail Ratings data items |  -  |
| **400** | Bad Request. This can occur for several reasons. Please review the \&quot;message\&quot; for more details. |  -  |
| **401** | Unauthenticated USERNAME-SERIAL. Ensure you are logged in and have successfully generated an API KEY for the IP range you are connecting from. For more help, select the **Report Issue** in the top right corner of this Developer Portal specification card and choose Connectivity 401 or 403 Responses. |  -  |
| **403** | The USERNAME-SERIAL attempted to request the endpoint is not authorized to access. The request was a legal request, but the server is refusing to respond. Please reach out to FactSet Account Team for assistance with authorization. |  -  |
| **415** | Unsupported Media Type. This error may be returned when the caller sends a resource in a format that is not accepted by the server. This can be fixed by ensuring that Content-Type header is set to the correct value. In this instance, \&quot;application/json\&quot; would be the appropriate value. |  -  |
| **500** | Internal Server Error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

