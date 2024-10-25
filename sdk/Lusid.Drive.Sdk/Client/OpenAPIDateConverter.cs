/*
 * FINBOURNE Drive API
 *
 * Drive is a secure file repository and manager that can act as a staging area for LUSID. You can upload files to Drive in preparation for loading investment data into LUSID, or export data from LUSID to Drive for consumption by external systems. Or simply share files with other LUSID users.  ### Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"165\">165</a>|Failed To Delete|  | | <a name=\"664\">664</a>|Folder already exists|  | | <a name=\"665\">665</a>|Destination directory not found|  | | <a name=\"666\">666</a>|Unknown Identifier|  | | <a name=\"668\">668</a>|Root directory not present|  | | <a name=\"669\">669</a>|Failed to create root directory|  | | <a name=\"670\">670</a>|File size exceeds maximum limit|  | | <a name=\"671\">671</a>|File already exists|  | | <a name=\"672\">672</a>|Could not retrieve file contents|  | | <a name=\"683\">683</a>|Full path to resource is too long|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"696\">696</a>|Unexpected payload size|  | | <a name=\"715\">715</a>|Restricted from downloading file containing malware.|  | | <a name=\"716\">716</a>|Restricted from downloading file whilst virus scan in progress.|  | | <a name=\"871\">871</a>|The specified impersonated user does not exist|  | 
 *
 * The version of the OpenAPI document: 0.1.672
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using Newtonsoft.Json.Converters;

namespace Lusid.Drive.Sdk.Client
{
    /// <summary>
    /// Formatter for 'date' openapi formats ss defined by full-date - RFC3339
    /// see https://github.com/OAI/OpenAPI-Specification/blob/master/versions/3.0.0.md#data-types
    /// </summary>
    public class OpenAPIDateConverter : IsoDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIDateConverter" /> class.
        /// </summary>
        public OpenAPIDateConverter()
        {
            // full-date   = date-fullyear "-" date-month "-" date-mday
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
