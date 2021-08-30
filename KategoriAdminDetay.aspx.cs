using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Yemek_Tarifleri_Sitem2
{
	public partial class KategoriAdminDetay : System.Web.UI.Page
	{
		SqlConnection bgl = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Dbo_YemekTarifi;Integrated Security=True;");
		private string id;
		protected void Page_Load(object sender, EventArgs e)
		{
			if (Page.IsPostBack==false)
			{
				bgl.Open();
				id = Request.QueryString["Kategoriid"];
				SqlCommand command = new SqlCommand("Select * from Tbl_Kategoriler where kategoriid=@p1", bgl);
				//command.Parameters.AddWithValue("@p1", id);
				command.Parameters.AddWithValue("@p1", SqlDbType.Int).Value = id ?? (object)DBNull.Value;
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					TextBox1.Text = reader[1].ToString();
					TextBox2.Text = reader[2].ToString();

				}

				bgl.Close();
			}
			
			
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			bgl.Open();
			SqlCommand command=new SqlCommand( "update Tbl_Kategoriler set kategoriad=@p1, kategoriadet=@p2 where kategoriid=@p3",bgl);
			command.Parameters.AddWithValue("@p1", TextBox1.Text);
			command.Parameters.AddWithValue("@p2", TextBox2.Text);
			command.Parameters.AddWithValue("@p3", SqlDbType.Int).Value = id ?? (object) DBNull.Value;
			Response.Write("Sayfa güncellendi");
			command.ExecuteNonQuery();
			bgl.Close();

		}
	}
}