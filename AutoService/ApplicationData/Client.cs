//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoService.ApplicationData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.ClientService = new HashSet<ClientService>();
            this.ClientTag = new HashSet<ClientTag>();
        }

        public int IdClient { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string IdGender { get; set; }
        public string Phone { get; set; }
        public string Photo { get; set; }
        public System.DateTime BirhDate { get; set; }
        public string Emall { get; set; }
        public System.DateTime RegDate { get; set; }
        public Nullable<int> IdTag { get; set; }
        public Nullable<int> BonusCardId { get; set; }
        public Nullable<int> IdPhoto { get; set; }
    
        public virtual BonusCard BonusCard { get; set; }
        public virtual ClientPhoto ClientPhoto { get; set; }
        public virtual Gender Gender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientService> ClientService { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientTag> ClientTag { get; set; }
        
        public string FIO { get => $"{ FirstName } { LastName } { MiddleName }"; }
    }
}
