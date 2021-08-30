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
	public partial class Kategoriler : System.Web.UI.Page
	{
		SqlConnection bgl = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Dbo_YemekTarifi;Integrated Security=True;");
		private string id = "";
		private string islem="";
		protected void Page_Load(object sender, EventArgs e)
		{
			Kapi();
			if (Page.IsPostBack==false)
			{
				id = Request.QueryString["Kategoriid"];
				islem = Request.QueryString["id"];
			}
			SqlCommand komut=new SqlCommand("Select * from Tbl_Kategoriler",bgl);
			SqlDataReader reader = komut.ExecuteReader();
			DataList1.DataSource = reader;
			DataList1.DataBind();

			//silme islemi

			if (islem=="sil")
			{
				
				SqlCommand command2=new SqlCommand("Delete From Tbl_Kategoriler where kategoriid=@p1",bgl);
				//command2.Parameters.AddWithValue("@p1",SqlDbType.Int).Value = id ?? (object) DBNull.Value;
				command2.Parameters.AddWithValue("@p1", id);
				command2.ExecuteNonQuery();
				Response.Write("Şeçili Alan Silinmiştir");
				bgl.Close();
			}






			bgl.Close();
			Panel2.Visible = false;
			Panel4.Visible = false;
		}

		public void Kapi()
		{
			if (bgl.State==ConnectionState.Closed)
			{
				bgl.Open();
			}
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			Panel2.Visible = true;
		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			Panel2.Visible = false;
		}

		protected void Button3_Click(object sender, EventArgs e)
		{
			Panel4.Visible = true;

		}

		protected void Button4_Click(object sender, EventArgs e)
		{
			Panel4.Visible = false;
		}

		protected void Button5_Click(object sender, EventArgs e)
		{
			Kapi();
			SqlCommand command=new SqlCommand("Insert into Tbl_Kategoriler (KategoriAd) values(@p1)",bgl);
			command.Parameters.AddWithValue("@p1", TextBox1.Text);
			command.ExecuteNonQuery();
			bgl.Close();
		}
	}
}