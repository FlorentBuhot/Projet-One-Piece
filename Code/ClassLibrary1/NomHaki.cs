using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClassLibrary1
{
    [DataContract]
    public enum NomHaki
    {
        [EnumMember]
        Haki_des_rois,
        [EnumMember]
        Haki_du_renforcement,
        [EnumMember]
        Haki_de_perception
    }
}
