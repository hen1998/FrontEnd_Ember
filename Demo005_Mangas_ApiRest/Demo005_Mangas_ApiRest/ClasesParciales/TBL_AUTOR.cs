using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Demo005_Mangas_ApiRest
{
    public partial class TBL_AUTOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_AUTOR()
        {
            this.TBL_MANGA = new List<TBL_MANGA>();
        }

        [XmlIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<TBL_MANGA> TBL_MANGA { get; set; }
    }
}