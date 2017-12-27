using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using PassportCommon;
using PassportInterface;
using PassportDataAccess;

namespace PassportBusiness

{
    public class Entrydetail : interface_Entrydetail
    {

        private String _RegestrationNumber;
        private String _PostCode;
        private String _CandidateName;
        private String _Aadharnumber;
        private String _FatherHusbandName;
        private String _Retiredemployee;
        private String _MotherName;
        private DateTime _DOB;
        private String _Age;
        private String _Address;
        private String _City;
        private String _State;
        private Int32 _PinCode;
        private String _PermanentAddress;
        private String _PermanentCity;
        private String _PermanentState;
        private Int32 _PermanentPinCode;
        private String _Nationality;
        private String _Gender;
        private String _MaritalStatus;
        private String _debarredGovt;
        private String _Category;
        private String _Sub_Categorytype;
        private String _Sub_Category;
        private DateTime _JoiningDate;
        private DateTime _LeavingDate;
        private String _Certificate_Number;
        private DateTime _Issue_Date;
        private String _Issuing_Authority;
        private String _Issuing_Authority_Email;
        private String _Handicap_Sub_Category;
        private String _Contact_Number;
        private String _Email;
        private String _Block;
        private String _Area;
        private String _PermanentBlock;
        private String _PermanentArea;
        private String _P_contactnumber;
        private String _C_contactnumber;
        private String _NationalityName;
        private String _Postapplied;
        private String _Year;
        private String _Password;
        private String _Email_field;
        private String _Mobile_Number;
        private String _Matrialstatustype;
        private String _SHG;
        private String _HSRLM;
        private String _Cadre;

        public Entrydetail()
        {
        }

        #region interface_Entrydetail Members

        // Basic info Start
        public String RegestrationNumber { get { return _RegestrationNumber; } set { _RegestrationNumber = value; } }
        public String PostCode { get { return _PostCode; } set { _PostCode = value; } }
        public String CandidateName { get { return _CandidateName; } set { _CandidateName = value; } }
        public String Aadharnumber { get { return _Aadharnumber; } set { _Aadharnumber = value; } }
        public String Retiredemployee { get { return _Retiredemployee; } set { _Retiredemployee = value; } }
        public String FatherHusbandName { get { return _FatherHusbandName; } set { _FatherHusbandName = value; } }
        public String MotherName { get { return _MotherName; } set { _MotherName = value; } }
        public DateTime DOB { get { return _DOB; } set { _DOB = value; } }
        public String Age { get { return _Age; } set { _Age = value; } }
        public String Address { get { return _Address; } set { _Address = value; } }
        public String City { get { return _City; } set { _City = value; } }
        public String State { get { return _State; } set { _State = value; } }
        public Int32 PinCode { get { return _PinCode; } set { _PinCode = value; } }
        public String PermanentAddress { get { return _PermanentAddress; } set { _PermanentAddress = value; } }
        public String PermanentCity { get { return _PermanentCity; } set { _PermanentCity = value; } }
        public String PermanentState { get { return _PermanentState; } set { _PermanentState = value; } }
        public Int32 PermanentPinCode { get { return _PermanentPinCode; } set { _PermanentPinCode = value; } }
        public String Nationality { get { return _Nationality; } set { _Nationality = value; } }
        public String Gender { get { return _Gender; } set { _Gender = value; } }
        public String MaritalStatus { get { return _MaritalStatus; } set { _MaritalStatus = value; } }
        public String debarredGovt { get { return _debarredGovt; } set { _debarredGovt = value; } }
        public String Category { get { return _Category; } set { _Category = value; } }
        public String Sub_Category { get { return _Sub_Category; } set { _Sub_Category = value; } }
        public String Sub_Categorytype { get { return _Sub_Categorytype; } set { _Sub_Categorytype = value; } }
        public DateTime JoiningDate { get { return _JoiningDate; } set { _JoiningDate = value; } }
        public DateTime LeavingDate { get { return _LeavingDate; } set { _LeavingDate = value; } }
        public String Certificate_Number { get { return _Certificate_Number; } set { _Certificate_Number = value; } }
        public DateTime Issue_Date { get { return _Issue_Date; } set { _Issue_Date = value; } }
        public String Issuing_Authority { get { return _Issuing_Authority; } set { _Issuing_Authority = value; } }
        public String Issuing_Authority_Email { get { return _Issuing_Authority_Email; } set { _Issuing_Authority_Email = value; } }
        public String Handicap_Sub_Category { get { return _Handicap_Sub_Category; } set { _Handicap_Sub_Category = value; } }
        public String Contact_Number { get { return _Contact_Number; } set { _Contact_Number = value; } }
        public String P_contactnumber { get { return _P_contactnumber; } set { _P_contactnumber = value; } }
        public String C_contactnumber { get { return _C_contactnumber; } set { _C_contactnumber = value; } }
        public String Block { get { return _Block; } set { _Block = value; } }
        public String Area { get { return _Area; } set { _Area = value; } }
        public String PermanentBlock { get { return _PermanentBlock; } set { _PermanentBlock = value; } }
        public String PermanentArea { get { return _PermanentArea; } set { _PermanentArea = value; } }
        public String Email { get { return _Email; } set { _Email = value; } }
        public String NationalityName { get { return _NationalityName; } set { _NationalityName = value; } }
        public String Postapplied { get { return _Postapplied; } set { _Postapplied = value; } }
        public String Year { get { return _Year; } set { _Year = value; } }
        public String Password { get { return _Password; } set { _Password = value; } }
        public String Email_field { get { return _Email_field; } set { _Email_field = value; } }
        public String Mobile_Number { get { return _Mobile_Number; } set { _Mobile_Number = value; } }
        public String Matrialstatustype { get { return _Matrialstatustype; } set { _Matrialstatustype = value; } }
        public String SHG { get { return _SHG; } set { _SHG = value; } }
        public String HSRLM { get { return _HSRLM; } set { _HSRLM = value; } }
        public String Cadre { get { return _Cadre; } set { _Cadre = value; } }
        //Address End

        #endregion



       

        public DataSet CreateRecord()
        {
            return DAC_Entrydetail.CreateRecord(this);
        }
        public DataSet UpdateRecord(String _regno)
        {
           return DAC_Entrydetail.UpdateRecord(this, _regno);
        }
  
        // fill methods
  

        public static SqlDataReader fillcategory()
        {
            SqlDataReader dr;
            dr = DAC_Entrydetail.fillcategory();
            return dr;
        }
        public static SqlDataReader fillGradqual()
        {
            SqlDataReader dr;
            dr = DAC_Entrydetail.fillGradqual();
            return dr;
        }
        public static SqlDataReader fillPGradqual()
        {
            SqlDataReader dr;
            dr = DAC_Entrydetail.fillPGradqual();
            return dr;
        }
        public static SqlDataReader fillDistrict()
        {
            SqlDataReader dr;
            dr = DAC_Entrydetail.fillDistrict();
            return dr;
        }
        
        
        // find methods


        public DataSet find_rec(string srno,String Regno, String password)
        {
            DataSet ds;
            ds = DAC_Entrydetail.find_rec(srno,Regno, password);
            return ds;
        }

        public DataSet find_record( String Regno, String password)
        {
            DataSet ds;
            ds = DAC_Entrydetail.find_record(Regno, password);
            return ds;
        }
      

        public static DataSet find_category(Int32 categorycode)
        {
            DataSet ds;
            ds = DAC_Entrydetail.find_category(categorycode);
            return ds;
        }

        public static DataSet find_Image(String RegestrationNumber)
        {
            DataSet ds;
            ds = DAC_Entrydetail.find_Image(RegestrationNumber);
            return ds;
        }

        public static DataSet bind_repeter(String RegestrationNumber)
        {
            /// Qualification
            DataSet ds;
            ds = DAC_Entrydetail.find_Repeter(RegestrationNumber);
          return ds;
        }

        public static DataSet bind_repeterEXP(String RegestrationNumber)
        {
            /// Qualification
            DataSet dsEXP;
            dsEXP = DAC_Entrydetail.find_RepeterExp(RegestrationNumber);
            return dsEXP;
        }
        public static DataSet find_ImageSignature(String RegestrationNumber)
        {
            DataSet ds;
            ds = DAC_Entrydetail.find_ImageSignature(RegestrationNumber);
            return ds;
        }
        public static DataSet Get_Qualification(String RegestrationNumber)
        {
            DataSet ds1;
            ds1 = DAC_Entrydetail.get_Qualification(RegestrationNumber);
            return ds1;
        }

        public static DataSet Get_Experience(String RegestrationNumber)
        {
            DataSet ds1;
            ds1 = DAC_Entrydetail.Get_Experience(RegestrationNumber);
            return ds1;
        }


        public static DataSet find_postname(Int32 _Postcode)
        {
            DataSet ds;
            ds = DAC_Entrydetail.find_postname(_Postcode);
            return ds;
        }
        public static DataSet find_schoolpref(Int32 _Schoolcode)
        {
            DataSet ds;
            ds = DAC_Entrydetail.find_schoolpref(_Schoolcode);
            return ds;
        }

        public static DataSet Fillgrid()
        {
            DataSet ds;
            ds = DAC_Entrydetail.Fillgrid();
            return ds;
        }

    
    }

}
