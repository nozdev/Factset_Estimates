# FactsetEstimatesClient.Api.EstimatesAndRatingsReportsApi

All URIs are relative to *https://api.factset.com/content*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAnalystRatings**](EstimatesAndRatingsReportsApi.md#getanalystratings) | **GET** /factset-estimates/v2/company-reports/analyst-ratings | Retrieves the historical monthly view of analyst ratings for a given identifier. |
| [**GetEstimateTypes**](EstimatesAndRatingsReportsApi.md#getestimatetypes) | **GET** /factset-estimates/v2/company-reports/estimate-types | Returns a list of valid estimate types. |
| [**GetEstimates**](EstimatesAndRatingsReportsApi.md#getestimates) | **GET** /factset-estimates/v2/company-reports/forecast | Returns forecasted estimates. |
| [**GetSurpriseHistory**](EstimatesAndRatingsReportsApi.md#getsurprisehistory) | **GET** /factset-estimates/v2/company-reports/surprise-history | Surprise History |

<a id="getanalystratings"></a>
# **GetAnalystRatings**
> AnalystRatingResponse GetAnalystRatings (string id)

Retrieves the historical monthly view of analyst ratings for a given identifier.

Returns historical monthly view of analyst ratings for given identifier upto a period of 12 months. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The requested security identifier. Accepted ID types include Market Tickers, SEDOL, ISINs, CUSIPs, or FactSet Permanent IDs.  |  |

### Return type

[**AnalystRatingResponse**](AnalystRatingResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Analyst-ratings data items |  -  |
| **400** | Bad Request. This can occur for several reasons. Please review the \&quot;message\&quot; for more details. |  -  |
| **401** | Unauthenticated USERNAME-SERIAL. Ensure you are logged in and have successfully generated an API KEY for the IP range you are connecting from. For more help, select the **Report Issue** in the top right corner of this Developer Portal specification card and choose Connectivity 401 or 403 Responses. |  -  |
| **403** | The USERNAME-SERIAL attempted to request the endpoint is not authorized to access. The request was legal, but the server is refusing to respond. Please reach out to FactSet Account Team for assistance with authorization. |  -  |
| **404** | The requested endpoint could not be found. |  -  |
| **415** | Unsupported Media Type. This error may be returned when the caller sends a resource in a format that is not accepted by the server. This can be fixed by ensuring that Content-Type header is set to the correct value. In this instance, \&quot;application/json\&quot; would be the appropriate value. |  -  |
| **500** | Internal Server Error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getestimatetypes"></a>
# **GetEstimateTypes**
> EstimateTypesResponse GetEstimateTypes ()

Returns a list of valid estimate types.

This endpoint retrieves a list of valid estimate types that can be used in the /company-reports/forecast and /company-reports/surprise-history end points. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**EstimateTypesResponse**](EstimateTypesResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Estimate type data items |  -  |
| **400** | Bad Request. This can occur for several reasons. Please review the \&quot;message\&quot; for more details. |  -  |
| **401** | Unauthenticated USERNAME-SERIAL. Ensure you are logged in and have successfully generated an API KEY for the IP range you are connecting from. For more help, select the **Report Issue** in the top right corner of this Developer Portal specification card and choose Connectivity 401 or 403 Responses. |  -  |
| **403** | The USERNAME-SERIAL attempted to request the endpoint is not authorized to access. The request was legal, but the server is refusing to respond. Please reach out to FactSet Account Team for assistance with authorization. |  -  |
| **404** | The requested endpoint could not be found. |  -  |
| **415** | Unsupported Media Type. This error may be returned when the caller sends a resource in a format that is not accepted by the server. This can be fixed by ensuring that Content-Type header is set to the correct value. In this instance, \&quot;application/json\&quot; would be the appropriate value. |  -  |
| **500** | Internal Server Error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getestimates"></a>
# **GetEstimates**
> EstimateResponse GetEstimates (string id, string estimateType, string periodicity = null)

Returns forecasted estimates.

This endpoint returns up to 4 years of forecasted consensus estimates made by analysts for various financial metrics such as EPS, Sales, and more.  **Note :**   Due to variations in methodology, with the workstation using intra-day prices and our API using the previous day's closing prices, there may be some minor differences in the values of FactSet Estimates Valuation Items. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The requested security identifier. Accepted ID types include Market Ticker, SEDOL, ISIN, CUSIP, or FactSet Permanent Id. |  |
| **estimateType** | **string** | The requested estimate type. Please use /meta/estimate-types to find all allowed values for this parameter. |  |
| **periodicity** | **string** | The periodicity for the estimates requested, allowing you to fetch Quarterly and Annual Estimates.   * **ANN** - Annual   * **QTR** - Quarterly  | [optional] [default to ANN] |

### Return type

[**EstimateResponse**](EstimateResponse.md)

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
| **403** | The USERNAME-SERIAL attempted to request the endpoint is not authorized to access. The request was legal, but the server is refusing to respond. Please reach out to FactSet Account Team for assistance with authorization. |  -  |
| **404** | The requested endpoint could not be found. |  -  |
| **415** | Unsupported Media Type. This error may be returned when the caller sends a resource in a format that is not accepted by the server. This can be fixed by ensuring that Content-Type header is set to the correct value. In this instance, \&quot;application/json\&quot; would be the appropriate value. |  -  |
| **500** | Internal Server Error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsurprisehistory"></a>
# **GetSurpriseHistory**
> SurpriseHistoryResponse GetSurpriseHistory (string id, string estimateType, string periodicity = null, int paginationLimit = null, int paginationOffset = null)

Surprise History

Returns surprise history for the given security


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The requested security identifier. Accepted ID types include Market Ticker, SEDOL, ISIN, CUSIP, or FactSet Permanent Id. |  |
| **estimateType** | **string** | The requested estimate type. Please use /meta/estimate-types to find all allowed values for this parameter. |  |
| **periodicity** | **string** | The periodicity for the estimates requested, allowing you to fetch Quarterly and Annual Estimates.   * **ANN** - Annual   * **QTR** - Quarterly  | [optional] [default to ANN] |
| **paginationLimit** | **int** | Specifies the number of results to return per page. | [optional] [default to 50] |
| **paginationOffset** | **int** | Specifies the starting point for pagination. This parameter is used to identify the beginning of next set of results. | [optional] [default to 0] |

### Return type

[**SurpriseHistoryResponse**](SurpriseHistoryResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **400** | Bad Request. This can occur for several reasons. Please review the \&quot;message\&quot; for more details. |  -  |
| **401** | Unauthenticated USERNAME-SERIAL. Ensure you are logged in and have successfully generated an API KEY for the IP range you are connecting from. For more help, select the **Report Issue** in the top right corner of this Developer Portal specification card and choose Connectivity 401 or 403 Responses. |  -  |
| **403** | The USERNAME-SERIAL attempted to request the endpoint is not authorized to access. The request was legal, but the server is refusing to respond. Please reach out to FactSet Account Team for assistance with authorization. |  -  |
| **404** | The requested endpoint could not be found. |  -  |
| **415** | Unsupported Media Type. This error may be returned when the caller sends a resource in a format that is not accepted by the server. This can be fixed by ensuring that Content-Type header is set to the correct value. In this instance, \&quot;application/json\&quot; would be the appropriate value. |  -  |
| **500** | Internal Server Error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

