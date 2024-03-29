//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Circus.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cell
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cell()
        {
            this.SheduleTrainers = new HashSet<SheduleTrainers>();
        }
    
        public int IDCellAnimal { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> AgeDate { get; set; }
        public Nullable<int> IDGender { get; set; }
        public Nullable<int> Weight { get; set; }
        public string FoodPreferences { get; set; }
        public string Recommendations { get; set; }
        public Nullable<int> IDAnimalTrainer { get; set; }
    
        public virtual Gender Gender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SheduleTrainers> SheduleTrainers { get; set; }
    }
}
