
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace datamodel
{

using System;
    using System.Collections.Generic;
    
public partial class Book
{

    public int Id { get; set; }

    public Nullable<int> Author_id { get; set; }

    public Nullable<int> Maker_id { get; set; }

    public string BookName { get; set; }

    public Nullable<System.DateTime> Year { get; set; }

    public Nullable<int> Count { get; set; }

    public string Comment { get; set; }

    public Nullable<int> Category_id { get; set; }



    public virtual Author Author { get; set; }

    public virtual Maker Maker { get; set; }

}

}
