using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CLSLms
{
    public class CourseUnitMetaData
    {
        public long unit_id { get; set; }
        public long courseid { get; set; }
        [LocalizedDisplayName("fldUnitType", NameResourceType = typeof(LMSResourse.Admin.Course))]
        public byte unit_type { get; set; }
        [LocalizedDisplayName("fldUnitOrder", NameResourceType = typeof(LMSResourse.Admin.Course))]
        public int unit_order { get; set; }
        [AllowHtml]
        [LocalizedDisplayName("fldUnitContent", NameResourceType = typeof(LMSResourse.Admin.Course))]
        public string unit_content { get; set; }
        [LocalizedDisplayName("fldUnitPathURL", NameResourceType = typeof(LMSResourse.Admin.Course))]
        public string unit_path_url { get; set; }
        [StringLength(100)]
        [Required(ErrorMessageResourceName = "msgReqCourseUnitName", ErrorMessageResourceType = typeof(LMSResourse.Admin.Course))]
        [LocalizedDisplayName("fldCourseUnitName", NameResourceType = typeof(LMSResourse.Admin.Course))]
        public string unit_name { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<System.DateTime> modified_date { get; set; }
        public Nullable<long> created_by { get; set; }
        public Nullable<long> modified_by { get; set; }
        [LocalizedDisplayName("fldUnitAudioContent", NameResourceType = typeof(LMSResourse.Admin.Course))]
        public int audio_delay { get; set; }
    }
    [MetadataType(typeof(CourseUnitMetaData))]
    public partial class CourseUnit
    {

    }
}
