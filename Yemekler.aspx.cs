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
	public partial class Yemekler : System.Web.UI.Page
	{
		SqlConnection bgl = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Dbo_YemekTarifi;Integrated Security=True;");
		protected void Page_Load(object sender, EventArgs e)
		{
			bgl.Open();
			Panel4.Visible = false;
			Panel2.Visible = false;
			
			SqlCommand komut =new SqlCommand("Select * from Tbl_Yemekler ",bgl);
			SqlDataReader reader = komut.ExecuteReader();
			DataList1.DataSource = reader;
			DataList1.DataBind();
			bgl.Close();


			if (Page.IsPostBack==false)
			{
				bgl.Open();
			SqlCommand command=new SqlCommand("Select * from Tbl_Kategoriler ",bgl);
			SqlDataReader reader3 = command.ExecuteReader();

			DropDownList1.DataTextField = "KategoriAd";
			DropDownList1.DataValueField = "Kategoriid";

			DropDownList1.DataSource = reader3;
			DropDownList1.DataBind();

			}

			
			
			
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			Panel2.Visible = true;
		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			Panel4.Visible = false;
		}

		protected void Button3_Click(object sender, EventArgs e)
		{
			Panel4.Visible = true;

		}

		protected void Button4_Click(object sender, EventArgs e)
		{
			Panel4.Visible = false;
		}

		protected void btnEkle_Click(object sender, EventArgs e)
		{
			bgl.Open();
			SqlCommand commmand=new SqlCommand("Insert into Tbl_Yemekler (yemekad,yemekmalzeme,yemektarif,kategoriid) values(@p1,@p2,@p3,@p4)",bgl);
			commmand.Parameters.AddWithValue("@p1",TextBox1.Text);
			commmand.Parameters.AddWithValue("@p2", TextBox2.Text);
			commmand.Parameters.AddWithValue("@p3", TextBox3.Text);
			commmand.Parameters.AddWithValue("@p4",DropDownList1.SelectedValue);
			commmand.ExecuteNonQuery();
			bgl.Close();
		}
	}
}