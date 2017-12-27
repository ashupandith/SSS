using System;
using System.Collections.Generic;
using System.Text;


/// <summary>
/// Summary description for interface_card
/// </summary>
/// 

namespace PassportInterface
{
    public interface interface_Entrydetail
    {

        /// <summary>
        ///  Application 
        /// </summary>
        String RegestrationNumber { get; set; }
        String PostCode { get; set; }
        String CandidateName { get; set; }
        String Aadharnumber { get; set; }
        String Retiredemployee { get; set; }
        String FatherHusbandName { get; set; }
        String MotherName { get; set; }
        DateTime DOB { get; set; }
        String Age { get; set; }
        String Address { get; set; }
        String City { get; set; }
        String State { get; set; }
        Int32 PinCode { get; set; }
        String PermanentAddress { get; set; }
        String PermanentCity { get; set; }
        String PermanentState { get; set; }
        Int32 PermanentPinCode { get; set; }
        String Nationality { get; set; }
        String Gender { get; set; }
        String MaritalStatus { get; set; }
        String debarredGovt { get; set; }
        String Category { get; set; }
        String Sub_Category { get; set; }
        String Sub_Categorytype { get; set; }
        DateTime JoiningDate { get; set; }
        DateTime LeavingDate { get; set; }
        String Certificate_Number { get; set; }
        DateTime Issue_Date { get; set; }
        String Issuing_Authority { get; set; }
        String Issuing_Authority_Email { get; set; }
        String Handicap_Sub_Category { get; set; }
        String Contact_Number { get; set; }
        String P_contactnumber { get; set; }
        String C_contactnumber { get; set; }
        String Email { get; set; }
        String Block { get; set; }
        String Area { get; set; }
        String PermanentBlock { get; set; }
        String PermanentArea { get; set; }
        String NationalityName { get; set; }
        String Postapplied { get; set; }
        String Year { get; set; }
        String Password { get; set; }
        String Email_field { get; set; }
        String Mobile_Number { get; set; }
        String Matrialstatustype { get; set; }
        String SHG { get; set; }
        String HSRLM { get; set; }
        String Cadre { get; set; }
        // Address End
    }

}