
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace SchoolPortalAPI.DataBase
{

using System;
    using System.Collections.Generic;
    
public partial class Lessons
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Lessons()
    {

        this.Marks = new HashSet<Marks>();

        this.TimeTable = new HashSet<TimeTable>();

    }


    public int Id { get; set; }

    public string Name { get; set; }

    public int TeacherId { get; set; }



    public virtual User User { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Marks> Marks { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<TimeTable> TimeTable { get; set; }

}

}
