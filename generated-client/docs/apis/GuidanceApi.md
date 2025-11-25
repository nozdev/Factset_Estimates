# FactsetEstimatesClient.Api.GuidanceApi

All URIs are relative to *https://api.factset.com/content*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetGuidance**](GuidanceApi.md#getguidance) | **GET** /factset-estimates/v2/guidance | Retrieves guidance for a requested list of ids and dates. |
| [**GetGuidanceForList**](GuidanceApi.md#getguidanceforlist) | **POST** /factset-estimates/v2/guidance | Retrieves guidance for a requested list of ids and dates. |

<a id="getguidance"></a>
# **GetGuidance**
> GuidanceResponse GetGuidance (List<string> ids, List<string> metrics, DateOnly startDate = null, DateOnly endDate = null, int relativeFiscalStart = null, int relativeFiscalEnd = null, string periodicity = null, string frequency = null, string currency = null)

Retrieves guidance for a requested list of ids and dates.

Returns FactSet Estimates guidance data for the current unreported period as of the requested dates. </p> 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | [**List&lt;string&gt;**](string.md) | Security or Entity identifiers. Accepted inputs include FactSet Identifiers, tickers, CUSIP, and SEDOL. &lt;p&gt;&lt;b&gt;Performance Note:&lt;/b&gt; Requests that increase the number of metrics or request long historical data may trigger the 30-second service timeout threshold. To ensure system stability and performance, please keep requests lightweight.&lt;/p&gt; &lt;p&gt;If requesting long historical data, limit the history to &lt;b&gt;10 years per metric per ID&lt;/b&gt;.&lt;/p&gt;  |  |
| **metrics** | [**List&lt;string&gt;**](string.md) | Requested metrics. Use the &#x60;/metrics&#x60; endpoint to return a list of available estimate items. **Top 10** most used metrics are **EPS, SALES, DPS, EBITDA,EBIT, PRICE_TGT, CFPS, BPS, NET_INC, and ASSETS**.  For more details, visit [Online Assistant Page #15034](https://oa.apps.factset.com/pages/15034).  |  |
| **startDate** | **DateOnly** | Start date for point in time of estimates expressed in YYYY-MM-DD format. | [optional]  |
| **endDate** | **DateOnly** | End date for point in time of estimates expressed in YYYY-MM-DD format. | [optional]  |
| **relativeFiscalStart** | **int** | Relative fiscal period, expressed as an integer, used to filter results. This is combined with the periodicity parameter to specify a relative estimate period. For example, set to 1 and periodicity to ANN to ask for relative Fiscal Year 1 (FY1). | [optional]  |
| **relativeFiscalEnd** | **int** | Relative fiscal period, expressed as an integer, used to filter results. This is combined with the periodicity parameter to specify a relative estimate period. For example, set to 2 and periodicity to ANN to ask for relative Fiscal Year 1 (FY2). | [optional]  |
| **periodicity** | **string** | The periodicity for the estimates requested, allowing you to fetch Quarterly, Semi-Annual, Annual, and NTMA/LTMA Estimates.   * **ANN** - Annual   * **QTR** - Quarterly   * **SEMI** - Semi-Annual    * **NTMA** - Next-Twelve-Months - Time-weighted Annual. Estimates use a percentage of annual estimates from two fiscal years to create an estimate based on the 12-month period. Visit [OA 16614](https://my.apps.factset.com/oa/pages/16614) for detail.   * **LTMA** - Last-Twelve-Months - Time-weighted Annual. Estimates use a percentage of annual estimates from two fiscal years to create an estimate based on the 12-month period. Visit [OA 16614](https://my.apps.factset.com/oa/pages/16614) for detail.     | [optional] [default to ANN] |
| **frequency** | **string** | Controls the frequency of the data returned.   * **D** &#x3D; Daily   * **W** &#x3D; Weekly, based on the last day of the week of the start date.   * **AM** &#x3D; Monthly, based on the start date (e.g., if the start date is June 16, data is displayed for June 16, May 16, April 16 etc.).         * **AQ** &#x3D; Quarterly, based on the start date.   * **AY** &#x3D; Actual Annual, based on the start date.   | [optional] [default to AM] |
| **currency** | **string** | Currency code for adjusting the data. Use &#x60;ESTIMATE&#x60; as input value for the values in Estimate Currency. For a list of currency ISO codes, visit [Online Assistant Page #1470](https://oa.apps.factset.com/pages/1470). | [optional]  |

### Return type

[**GuidanceResponse**](GuidanceResponse.md)

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

<a id="getguidanceforlist"></a>
# **GetGuidanceForList**
> GuidanceResponse GetGuidanceForList (GuidanceRequest guidanceRequest)

Retrieves guidance for a requested list of ids and dates.

Returns FactSet Estimates guidance data for the current unreported period as of the requested dates. <p> 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **guidanceRequest** | [**GuidanceRequest**](GuidanceRequest.md) | Request object for Estimate Data Items. |  |

### Return type

[**GuidanceResponse**](GuidanceResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Estimate metric Ids |  -  |
| **400** | Bad Request. This can occur for several reasons. Please review the \&quot;message\&quot; for more details. |  -  |
| **401** | Unauthenticated USERNAME-SERIAL. Ensure you are logged in and have successfully generated an API KEY for the IP range you are connecting from. For more help, select the **Report Issue** in the top right corner of this Developer Portal specification card and choose Connectivity 401 or 403 Responses. |  -  |
| **403** | The USERNAME-SERIAL attempted to request the endpoint is not authorized to access. The request was a legal request, but the server is refusing to respond. Please reach out to FactSet Account Team for assistance with authorization. |  -  |
| **415** | Unsupported Media Type. This error may be returned when the caller sends a resource in a format that is not accepted by the server. This can be fixed by ensuring that Content-Type header is set to the correct value. In this instance, \&quot;application/json\&quot; would be the appropriate value. |  -  |
| **500** | Internal Server Error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

