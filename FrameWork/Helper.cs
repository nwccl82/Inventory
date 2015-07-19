using System;
using System.Collections.Generic;
using System.Text;

namespace FrameWork
{
    public class Helper
    {

        public static void CopyProperties(System.Data.DataRow row, object destination)
        {
            Type destinationType = destination.GetType();

            System.Reflection.PropertyInfo[] proInfo = destinationType.GetProperties();

            foreach (System.Data.DataColumn col in row.Table.Columns)
            {
                string strValue = row[col.ColumnName].ToString();

                object val = strValue;

                if (strValue == "")
                {
                    val = string.Empty;
                }

                if (typeof(int) == col.DataType)
                {
                    if (val.ToString() == string.Empty || val == null)
                    {
                        val = 0;
                    }
                    val = int.Parse(val.ToString());
                }
                else if (typeof(double) == col.DataType || typeof(Decimal) == col.DataType)
                {
                    if (val.ToString() == string.Empty || val == null)
                    {
                        val = 0;
                    }
                    val = double.Parse(val.ToString());
                }
                else if (typeof(DateTime) == col.DataType)
                {
                    if (strValue == "")
                    {
                        val = new DateTime();
                    }
                    else
                    {
                        val = DateTime.Parse(val.ToString());

                    }

                }
                else if (typeof(byte[]) == col.DataType)
                {
                    if (val == null)
                    {
                        val = System.Text.Encoding.UTF8.GetBytes(string.Empty);
                    }
                    else
                    {
                        val = row[col.ColumnName];
                    }

                }

                //destinationType.GetProperty(col.ColumnName).SetValue(destination, val, null);    
                destinationType.GetProperty(col.ColumnName.Replace(" ", "")).SetValue(destination, val, null);
            }
        }
    }
}
