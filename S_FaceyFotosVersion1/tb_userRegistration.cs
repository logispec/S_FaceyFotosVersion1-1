//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S_FaceyFotosVersion1
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_userRegistration
    {
        public int Id { get; set; }
        public string UserID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email_Address { get; set; }
        public string Telephone { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public string Card_Number { get; set; }
        public int Card_TypeID { get; set; }
        public int CSV_Number { get; set; }
        public System.DateTime Expiration_Date { get; set; }
    
        public virtual tb_cardType tb_cardType { get; set; }
    }
}