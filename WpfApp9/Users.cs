//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp9
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public int Type { get; set; }
    
        public virtual UserType UserType { get; set; }
    }
}
