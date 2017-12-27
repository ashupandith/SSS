using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using PassportInterface;
using PassportCommon;
using Common;
using PassportBusiness;

namespace PassportDataAccess
{
    public class DAC_Entrydetail : Configuration
    {
  
        public static DataSet CreateRecord(interface_Entrydetail Entrydetail)
        {

            SqlParameter[] _parameters = {
            // Basic Info Start

            new SqlParameter( "@RegestrationNumber", Entrydetail.RegestrationNumber),
            new SqlParameter( "@PostCode", Entrydetail.PostCode),
            new SqlParameter( "@CandidateName", Entrydetail.CandidateName),
            new SqlParameter( "@Aadharnumber", Entrydetail.Aadharnumber),
            new SqlParameter( "@FatherHusbandName", Entrydetail.FatherHusbandName),
            new SqlParameter( "@Retiredemployee", Entrydetail.Retiredemployee),
            new SqlParameter( "@MotherName", Entrydetail.MotherName),
            new SqlParameter( "@DOB", Entrydetail.DOB),
             new SqlParameter( "@Password", Entrydetail.Password),
              new SqlParameter( "@Email_field", Entrydetail.Email_field),
               new SqlParameter( "@Mobile_Number", Entrydetail.Mobile_Number),
            };
            return SqlHelper.ExecuteDataset(ConnectionString, "UspAddApplication", _parameters);

        }
        public static DataSet UpdateRecord(interface_Entrydetail Entrydetail, String _RegestrationNumber)
        {

            SqlParameter[] _parameters = {
            // Basic Info Start
              new SqlParameter( "@RegestrationNumber", Entrydetail.RegestrationNumber),
             new SqlParameter( "@Address", Entrydetail.Address),
            new SqlParameter( "@City", Entrydetail.City),
            new SqlParameter( "@State", Entrydetail.State),
            new SqlParameter( "@PinCode", Entrydetail.PinCode),
            new SqlParameter( "@PermanentAddress", Entrydetail.PermanentAddress),
            new SqlParameter( "@PermanentCity", Entrydetail.PermanentCity),
            new SqlParameter( "@PermanentState", Entrydetail.PermanentState),
            new SqlParameter( "@PermanentPinCode", Entrydetail.PermanentPinCode),
            new SqlParameter( "@Nationality", Entrydetail.Nationality),
            new SqlParameter( "@Gender", Entrydetail.Gender),
            new SqlParameter( "@MaritalStatus", Entrydetail.MaritalStatus),
            new SqlParameter( "@debarredGovt", Entrydetail.debarredGovt),
            new SqlParameter( "@Category", Entrydetail.Category),
            new SqlParameter( "@Sub_Category", Entrydetail.Sub_Category),
            new SqlParameter( "@Sub_CategoryType", Entrydetail.Sub_Categorytype),
            new SqlParameter( "@JoiningDate", Entrydetail.JoiningDate),
            new SqlParameter( "@LeavingDate", Entrydetail.LeavingDate),
            new SqlParameter( "@Certificate_Number", Entrydetail.Certificate_Number),
            new SqlParameter( "@Issue_Date", Entrydetail.Issue_Date),
            new SqlParameter( "@Issuing_Authority", Entrydetail.Issuing_Authority),
            new SqlParameter( "@Issuing_Authority_Email", Entrydetail.Issuing_Authority_Email),
            new SqlParameter( "@Handicap_Sub_Category", Entrydetail.Handicap_Sub_Category),
            new SqlParameter( "@Contact_Number", Entrydetail.Contact_Number),
             new SqlParameter( "@Email", Entrydetail.Email),
            new SqlParameter( "@Perma_contact", Entrydetail.P_contactnumber),
            new SqlParameter( "@Corres_contact", Entrydetail.C_contactnumber),
             new SqlParameter( "@Block", Entrydetail.Block),
              new SqlParameter( "@Area", Entrydetail.Area),
              new SqlParameter( "@PermanentBlock", Entrydetail.PermanentBlock),
            new SqlParameter( "@PermanentArea", Entrydetail.PermanentArea),
            new SqlParameter( "@NationalityName", Entrydetail.NationalityName),
             new SqlParameter( "@Postapplied", Entrydetail.Postapplied),
              new SqlParameter( "@Year", Entrydetail.Year),
              new SqlParameter( "@Matrialstatustype", Entrydetail.Matrialstatustype),
               new SqlParameter( "@SHG", Entrydetail.SHG),
                new SqlParameter( "@HSRLM", Entrydetail.HSRLM),
                new SqlParameter( "@Cadre", Entrydetail.Cadre),
            // Address End
         
            };
            return SqlHelper.ExecuteDataset(ConnectionString, "UspUpdateApplication", _parameters);

        }

             //fill methods
        public static SqlDataReader fillcategory()
        {
            return SqlHelper.ExecuteReader(ConnectionString, CommandType.Text, "select * from tblcatgory where post_id=1");
        }
        public static SqlDataReader fillGradqual()
        {
            return SqlHelper.ExecuteReader(ConnectionString, CommandType.Text, "select RegestrationNumber,imagename from ApplicantDetails where Qualcode = 1 order by Qualificationcode ");
        }
        public static SqlDataReader fillPGradqual()
        {
            return SqlHelper.ExecuteReader(ConnectionString, CommandType.Text, "select * from SSB2010qualmaster where Qualcode = 2 order by Qualificationcode ");
        }
        public static SqlDataReader fillDistrict()
        {
            return SqlHelper.ExecuteReader(ConnectionString, CommandType.Text, "select * from SSB2010DistrictMaster order by DistrictName");
        }
     

        // find methods
        public static DataSet find_rec(String _srno, String _Regno, String _password)
        {
            SqlParameter[] _parameters = { new SqlParameter("@srno", _srno),
            new SqlParameter("@regno", _Regno),
            new SqlParameter( "@password", _password)
            };
            return SqlHelper.ExecuteDataset(ConnectionString, CommandType.Text, "Select *  from ApplicantDetails where PostCode = @srno and RegestrationNumber=@regno and Password=@password", _parameters);
        }
        public static DataSet find_record( String _Regno, String _password)
        {
            SqlParameter[] _parameters = { new SqlParameter("@regno", _Regno),
            new SqlParameter( "@password", _password)
            };
            return SqlHelper.ExecuteDataset(ConnectionString, CommandType.Text, "Select  a.*,CONVERT(VARCHAR(20), a.DOB, 103) AS DOBB,b.Post_name  from ApplicantDetails a,TblPost b where a.PostCode=b.id and  RegestrationNumber=@regno and Password=@password", _parameters);
        }
         public static DataSet find_category(Int32 _catcode)
        {
            SqlParameter[] _parameters = { new SqlParameter("@catcode", _catcode) };
            return SqlHelper.ExecuteDataset(ConnectionString, CommandType.Text, "Select *  from SSB2010CategoryMaster where categorycode = @catcode", _parameters);
        }
         public static DataSet find_Image(String _RegestrationNumber)
         {
             SqlParameter[] _parameters = { new SqlParameter("@RegestrationNumber", _RegestrationNumber) };
             return SqlHelper.ExecuteDataset(ConnectionString, CommandType.Text, "Select *  from ApplicantDetails where RegestrationNumber = @RegestrationNumber", _parameters);
         }
         public static DataSet find_Repeter(String _RegestrationNumber)
         {
             SqlParameter[] _parameters = { new SqlParameter("@RegestrationNumber", _RegestrationNumber) };
             return SqlHelper.ExecuteDataset(ConnectionString, CommandType.Text, "select  Exmanation,Board,CONVERT(VARCHAR(20), PassingYear, 103) AS PassingYear,TotalPercent,Subject ,MarksObtained,TotalMarks,Divison from ApplicantQualificationDetails where RegestrationNumber = @RegestrationNumber", _parameters);
         }
         public static DataSet find_RepeterExp(String _RegestrationNumber)
         {
             SqlParameter[] _parameters = { new SqlParameter("@RegestrationNumber", _RegestrationNumber) };
             return SqlHelper.ExecuteDataset(ConnectionString, CommandType.Text, "select  EmployerName,Designation,CONVERT(VARCHAR(20), FromDate, 103) AS FromDate,CONVERT(VARCHAR(20), ToDate, 103) AS ToDate,SalaryDrawn,NatureofDuty,SalaryDrawn from ApplicantExperienceDetails where RegestrationNumber = @RegestrationNumber", _parameters);
         }
         public static DataSet find_ImageSignature(String _RegestrationNumber)
         {
             SqlParameter[] _parameters = { new SqlParameter("@RegestrationNumber", _RegestrationNumber) };
             return SqlHelper.ExecuteDataset(ConnectionString, CommandType.Text, "Select *  from ApplicantDetails where RegestrationNumber = @RegestrationNumber", _parameters);
         }
         public static DataSet get_Qualification(String _RegestrationNumber)
         {
             SqlParameter[] _parameters = { new SqlParameter("@RegestrationNumber", _RegestrationNumber) };
             return SqlHelper.ExecuteDataset(ConnectionString, CommandType.Text, "Select *  from ApplicantQualificationDetails where RegestrationNumber = @RegestrationNumber", _parameters);
         }

         public static DataSet Get_Experience(String _RegestrationNumber)
         {
             SqlParameter[] _parameters = { new SqlParameter("@RegestrationNumber", _RegestrationNumber) };
             return SqlHelper.ExecuteDataset(ConnectionString, CommandType.Text, "Select *  from ApplicantExperienceDetails where RegestrationNumber = @RegestrationNumber", _parameters);
         }

         public static DataSet Check_ifExist(String _RegestrationNumber)
         {
             SqlParameter[] _parameters = { new SqlParameter("@RegestrationNumber", _RegestrationNumber) };
             return SqlHelper.ExecuteDataset(ConnectionString, CommandType.StoredProcedure, "CheckifExist", _parameters);
         }

        public static DataSet find_postname(Int32 _Postcode)
        {
            SqlParameter[] _parameters = { new SqlParameter("@Postcode", _Postcode) };
            return SqlHelper.ExecuteDataset(ConnectionString, CommandType.Text, "Select *  from SSB2010PostMaster where Postcode = @Postcode", _parameters);
        }
        public static DataSet find_schoolpref(Int32 _Schoolcode)
        {
            SqlParameter[] _parameters = { new SqlParameter("@Schoolcode", _Schoolcode) };
            return SqlHelper.ExecuteDataset(ConnectionString, CommandType.Text, "Select *  from SSB2010PreferenceMaster where Prefcode = @Schoolcode", _parameters);
        }
        public static DataSet Fillgrid()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, CommandType.Text, "select SSB2010PostMaster.postname,count(*)as records from dbo.SSAA2010Entrydetail,dbo.SSAA2010PostMaster where SSAA2010Entrydetail.postcode=SSAA2010PostMaster.postcode group by postname");
        }
                
 
     }
}

