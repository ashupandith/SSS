using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


public class dateclass
{
    private int[] monthDay = new int[12] { 31, -1, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    private DateTime fromDate;
    private DateTime toDate;
    private int year;
    private int month;
    private int day;
    public int Pyear
    {
        get
        {
            return year;
        }
        set
        {
            year = value;
        }
    }

    public int Pmonth
    {
        get
        {
            return month;
        }
        set
        {
            month = value;
        }
    }
    public int Pday
    {
        get
        {
            return day;
        }
        set
        {
            day = value;
        }
    }
    public dateclass DateDifference(DateTime d1, DateTime d2)
    {
        dateclass d = new dateclass();
        if (d1 > d2)
        {
            this.fromDate = d2;
            this.toDate = d1;
        }
        else
        {
            this.fromDate = d1;
            this.toDate = d2;
        }
        Int32 increment = 0;
        if (this.fromDate.Day > this.toDate.Day)
        {
            increment = this.monthDay[this.fromDate.Month - 1];
        }
        if (increment == -1)
        {
            if (DateTime.IsLeapYear(this.fromDate.Year))
            {
                increment = 29;
            }
            else
            {
                increment = 28;
            }
        }
        if (increment != 0)
        {
            d.day = (this.toDate.Day + increment) - this.fromDate.Day;
            increment = 1;
        }
        else
        {
            d.day = this.toDate.Day - this.fromDate.Day;
        }
        if ((this.fromDate.Month + increment) > this.toDate.Month)
        {
            d.month = (this.toDate.Month + 12) - (this.fromDate.Month + increment);
            increment = 1;
        }
        else
        {
            d.month = (this.toDate.Month) - (this.fromDate.Month + increment);
            increment = 0;
        }
        d.year = this.toDate.Year - (this.fromDate.Year + increment);
        return d;

    }


    public override string ToString()
    {
        return this.year + "Year(s), " + this.month + " month(s), " + this.day + " day(s)";
    }
}
