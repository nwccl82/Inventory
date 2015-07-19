using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DBCommand
    {

        public static int Execute(string command)
        {
            SqlCommand cmd = new SqlCommand(command, DBConnection.connect());

            return cmd.ExecuteNonQuery();
        }

        public static int Execute(SqlCommand command)
        {
            SqlCommand cmd = new SqlCommand(command.CommandText, DBConnection.connect());

            return cmd.ExecuteNonQuery();
        }
        public static int Execute(string command, byte[] image)
        {
            SqlCommand cmd = new SqlCommand(command, DBConnection.connect());
            cmd.Parameters.Add(new SqlParameter("@imagedata", (object)image));

            return cmd.ExecuteNonQuery();
        }
        public static int Execute(string command, byte[] signature1, byte[] signature2)
        {
            SqlCommand cmd = new SqlCommand(command, DBConnection.connect());
            cmd.Parameters.Add(new SqlParameter("@signature1", (object)signature1));
            cmd.Parameters.Add(new SqlParameter("@signature2", (object)signature2));

            return cmd.ExecuteNonQuery();
        }
        public static int Execute(string command, byte[] MemberSig, byte[] GuardianSig, byte[] IssuerSig)
        {
            SqlCommand cmd = new SqlCommand(command, DBConnection.connect());
            cmd.Parameters.Add(new SqlParameter("@MemberSig", (object)MemberSig));
            cmd.Parameters.Add(new SqlParameter("@GuardianSig", (object)GuardianSig));
            cmd.Parameters.Add(new SqlParameter("@IssuerSig", (object)IssuerSig));

            return cmd.ExecuteNonQuery();
        }
    }
}
