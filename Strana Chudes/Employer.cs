//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Strana_Chudes
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employer
    {
        public int tabNum { get; set; }
        public string name { get; set; }
        public System.DateTime dateStartWork { get; set; }
        public int position { get; set; }
        public decimal salary { get; set; }
        public string pasword { get; set; }
    
public string Datestartwork { get {
                TimeSpan days = DateTime.Now - dateStartWork;
                int years = days.Days / 365;
                int month = (days.Days - (years * 365)) / 30;
                return $"{years} лет {month} мес.";
            } }

        public string TitlePositions { get => Position1.Titile; }
        public virtual Position Position1 { get; set; }
    }
}