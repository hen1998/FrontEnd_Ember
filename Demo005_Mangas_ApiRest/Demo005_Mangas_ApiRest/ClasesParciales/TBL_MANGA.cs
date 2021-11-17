using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Demo005_Mangas_ApiRest
{
    public partial class TBL_MANGA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_MANGA()
        {
            this.TBL_CAPITULO = new List<TBL_CAPITULO>();
        }


        public virtual TBL_AUTOR TBL_AUTOR { get; set; }
        [XmlIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<TBL_CAPITULO> TBL_CAPITULO { get; set; }
        public virtual TBL_EDITORIAL TBL_EDITORIAL { get; set; }
    }
}