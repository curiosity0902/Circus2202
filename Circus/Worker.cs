
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
    
public partial class Worker
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Worker()
    {

        this.Task = new HashSet<Task>();

    }


    public int IDWorker { get; set; }

    public string Surname { get; set; }

    public string Name { get; set; }

    public string Patronymic { get; set; }

    public Nullable<System.DateTime> DateOfBirth { get; set; }

    public Nullable<int> IDRole { get; set; }

    public Nullable<int> IDGender { get; set; }

    public string Login { get; set; }

    public string Password { get; set; }



    public virtual Gender Gender { get; set; }

    public virtual Role Role { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Task> Task { get; set; }

}

}
