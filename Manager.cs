using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SedapMakanManagementSystem
{
    public class Manager
    {
        public int ManagerID { get; set; }
        public string Name { get; set; }

        public Manager(int id, string name)
        {
            ManagerID = id;
            Name = name;
        }

        public void RespondToFeedback(int feedbackId, string response)
        {
            using (SqlConnection conn = new SqlConnection("your_connection_string"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Feedback SET ManagerResponse=@Response, IsRead=1 WHERE FeedbackID=@FeedbackID", conn);
                cmd.Parameters.AddWithValue("@Response", response);
                cmd.Parameters.AddWithValue("@FeedbackID", feedbackId);
                cmd.ExecuteNonQuery();
            }
        }

        public void ApproveOrRejectRefund(int refundId, string status)
        {
            using (SqlConnection conn = new SqlConnection("your_connection_string"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE RefundRequests SET Status=@Status WHERE RefundID=@RefundID", conn);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@RefundID", refundId);
                cmd.ExecuteNonQuery();
            }
        }

        public void TopUpEWallet(int customerId, decimal amount)
        {
            using (SqlConnection conn = new SqlConnection("your_connection_string"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Users SET WalletBalance = WalletBalance + @Amount WHERE UserID=@CustomerID", conn);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

