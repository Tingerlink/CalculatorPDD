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
    
    public partial class act
    {
        public act()
        {
            this.item_list_prohibition = new HashSet<item_list_prohibition>();
            this.item_list_resolution = new HashSet<item_list_resolution>();
        }
    
        public long code_act { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<item_list_prohibition> item_list_prohibition { get; set; }
        public virtual ICollection<item_list_resolution> item_list_resolution { get; set; }
    }
}
