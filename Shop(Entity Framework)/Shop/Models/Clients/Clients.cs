//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clients
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string patronymic { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }

        public Clients(string firstName, string lastName, string patronymic, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.patronymic = patronymic;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public Clients()
        {

        }

        public override string ToString()
        {
            return $"{ id} { firstName} {lastName} {patronymic} {email}";
        }
    }
}
