
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Circus
{

using System;
    using System.Collections.Generic;
    
public partial class Application
{

    public int IDApplication { get; set; }

    public Nullable<int> IDAdmin { get; set; }

    public Nullable<int> IDArtist { get; set; }

    public string Description { get; set; }



    public virtual Admin Admin { get; set; }

    public virtual Artist Artist { get; set; }

}

}
