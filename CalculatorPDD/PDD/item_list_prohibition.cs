//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PDD
{
    using System;
    using System.Collections.Generic;
    
    public partial class item_list_prohibition
    {
        public long code_item_list_prohibition { get; set; }
        public long code_road_sign { get; set; }
        public long code_act { get; set; }
    
        public virtual act act { get; set; }
        public virtual road_sign road_sign { get; set; }
    }
}
