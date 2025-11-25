# FactsetEstimatesClient.Api.SegmentActualsApi

All URIs are relative to *https://api.factset.com/content*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetSegmentActuals**](SegmentActualsApi.md#getsegmentactuals) | **GET** /factset-estimates/v2/segment-actuals | Retrieves Segment Actuals for a requested list of ids and reported fiscal periods. |
| [**GetSegmentActualsForList**](SegmentActualsApi.md#getsegmentactualsforlist) | **POST** /factset-estimates/v2/segment-actuals | Retrieves Segment Actuals for a requested list of ids and reported fiscal periods. |

<a id="getsegmentactuals"></a>
# **GetSegmentActuals**
> SegmentActualsResponse GetSegmentActuals (List<string> ids, List<string> metrics, string segmentType, int relativeFiscalStart = null, int relativeFiscalEnd = null, string periodicity = null, string currency = null)

Retrieves Segment Actuals for a requested list of ids and reported fiscal periods.

Returns FactSet Estimates Actuals data using rolling fiscal dates for company business and geographic segments. <p> 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | [**List&lt;string&gt;**](string.md) | Security or Entity identifiers. Accepted inputs include FactSet Identifiers, tickers, CUSIP, and SEDOL. &lt;p&gt;&lt;b&gt;Performance Note:&lt;/b&gt; Requests that increase the number of metrics or request long historical data may trigger the 30-second service timeout threshold. To ensure system stability and performance, please keep requests lightweight.&lt;/p&gt; &lt;p&gt;If requesting long historical data, limit the history to &lt;b&gt;10 years per metric per ID&lt;/b&gt;.&lt;/p&gt;  |  |
| **metrics** | [**List&lt;string&gt;**](string.md) | Requested metrics for segment actuals. An asterisk denotes metric items included for geographic segments. Note, the number of metrics you are allowed to supply is limited to 1 for now. For more details, visit [Online Assistant Page #15034](https://oa.apps.factset.com/pages/15034).  &lt;h3&gt;Financial Metrics&lt;/h3&gt; |field|description| |- --|- --| |ASP|Average Selling Price| |ARR|Annual Recurring Revenue| |CAPEX|Capital Expenditures| |CCUR_GRTH*|Constant Currency Revenue Growth*| |COS*|Cost of Sales*| |CFO_GAAP|Chief Financial Officer (GAAP)| |DELIVERIES_UNITS|Deliveries Units| |EPS|Earnings Per Share| |EBIT*|Earnings Before Interest and Taxes*| |EBIT_REP|Earnings Before Interest and Taxes - Reported| |EBITDA*|Earnings Before Interest, Taxes, Depreciation, and Amortization*| |EBITDA_REP|Earnings Before Interest, Taxes, Depreciation, and Amortization - Reported| |G_A_EXP|General &amp; Admin Expense| |GROSS_INC*|Gross Income*| |GMV*|Gross Merchandise Volume*| |LCUR_GRTH*|Local Currency Revenue Growth*| |NET_ADDS|Net Adds| |NET_INC*|Net Profit*| |NET_SALES*|Net Sales*| |SUBSCRIBERS_NB*|Number of Subscribers*| |ORGANICGROWTH*|Organic Growth*| |PTX_INC|Pre-Tax Income| |RATEBASE*|Ratebase*| |AVGRATEBASE|Avg. Ratebase| |SALES*|Sales*| |SAMESTORESALES|Same Store Sales| |SGA|Selling, General &amp; Administrative Expenses| |S_M_EXP|Selling &amp; Marketing Expenses| |REV_TOT*|Total Revenues*|   &lt;h3&gt;Industry Metrics&lt;/h3&gt; |field|description| |- --|- --| |UNITS|Units| |NEW_ORDERS_VALUE*|Home Builders - New Orders Value*| |BACKLOG_VALUE|Home Builders - Backlog Value| |MCR|Hospitals - Medical Cost Ratio (%)| |CASH_COST|Mining - Cash Cost| |REAL_PRICE|Mining - Real Price| |DAU*|Social Media/Games - Daily Active Users*| |ARPU|Telecoms - Average Revenue Per User (ARPU)| |CONTR_PROF|Telecoms - Contribution Profit| |PAIDNADDS|Telecoms - Paid Net Adds|  |  |
| **segmentType** | **string** | Controls the type of segment selected.   * **BUS** &#x3D; Business / Product Segment   * **GEO** &#x3D; Geographic Segment  | [default to BUS] |
| **relativeFiscalStart** | **int** | Relative fiscal period, expressed as an integer, used to filter results. This is combined with the periodicity parameter to specify a relative estimate period. FactSet Estimates Actuals provides data for past periods. Therefore, the input for &#x60;relativeFiscalStart&#x60; must be an integer that is zero or less. For example, set to 0 and periodicity to ANN to ask for the current reported year (FY0).  | [optional]  |
| **relativeFiscalEnd** | **int** | Relative fiscal period, expressed as an integer, used to filter results. This is combined with the periodicity parameter to specify a relative estimate period.Therefore, the input for &#x60;relativeFiscalEnd&#x60; must be an integer that is zero or less.  For example, set to -2 and periodicity to ANN to ask for two fiscal years before the latest (FY-2). | [optional]  |
| **periodicity** | **string** | The periodicity for the estimates requested, allowing you to fetch Quarterly, Semi-Annual, Annual, and NTMA/LTMA Estimates.   * **ANN** - Annual   * **QTR** - Quarterly   * **SEMI** - Semi-Annual    * **NTMA** - Next-Twelve-Months - Time-weighted Annual. Estimates use a percentage of annual estimates from two fiscal years to create an estimate based on the 12-month period. Visit [OA 16614](https://my.apps.factset.com/oa/pages/16614) for detail.   * **LTMA** - Last-Twelve-Months - Time-weighted Annual. Estimates use a percentage of annual estimates from two fiscal years to create an estimate based on the 12-month period. Visit [OA 16614](https://my.apps.factset.com/oa/pages/16614) for detail.     | [optional] [default to ANN] |
| **currency** | **string** | Currency code for adjusting the data. Use &#x60;ESTIMATE&#x60; as input value for the values in Estimate Currency. For a list of currency ISO codes, visit [Online Assistant Page #1470](https://oa.apps.factset.com/pages/1470). | [optional]  |

### Return type

[**SegmentActualsResponse**](SegmentActualsResponse.md)

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

<a id="getsegmentactualsforlist"></a>
# **GetSegmentActualsForList**
> SegmentActualsResponse GetSegmentActualsForList (SegmentActualsRequest segmentActualsRequest)

Retrieves Segment Actuals for a requested list of ids and reported fiscal periods.

Returns FactSet Estimates Actuals data using rolling fiscal dates for company business and geographic segments. <p> 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **segmentActualsRequest** | [**SegmentActualsRequest**](SegmentActualsRequest.md) | Request object for Estimate Data Items. |  |

### Return type

[**SegmentActualsResponse**](SegmentActualsResponse.md)

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

