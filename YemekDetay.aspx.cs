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
	public partial class YemekDetay : System.Web.UI.Page
	{
		

		SqlConnection bgl = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Dbo_YemekTarifi;Integrated Security=True;");
		public string yemekid = "";
		protected void Page_Load(object sender, EventArgs e)
		{
			Kontrol();
			yemekid = Request.QueryString["yemekid"];
			
			SqlCommand command=new SqlCommand("Select YemekAd from Tbl_Yemekler where yemekid = @t1",bgl);
			//command.Parameters.AddWithValue("@t1", yemekid);
			command.Parameters.AddWithValue("@t1", SqlDbType.Int).Value = yemekid ?? (object)DBNull.Value;
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Label3.Text = reader[0].ToString();
			}
			reader.Close();
			bgl.Close();

			Kontrol();
			SqlCommand command2=new SqlCommand("Select * from Tbl_Yorumlar where yemekid = @t2", bgl);
			command2.Parameters.AddWithValue("@t2", SqlDbType.Int).Value = yemekid ?? (object)DBNull.Value;
			SqlDataReader reader2 = command2.ExecuteReader();
			DataList2.DataSource = reader2;
			DataList2.DataBind();

			reader.Close();
			bgl.Close();


		}

		public void Kontrol()
		{
			if (bgl.State==ConnectionState.Closed)
			{
				bgl.Open();
			}
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			Kontrol();
			SqlCommand komut=new SqlCommand("Insert into Tbl_Yorumlar  (YorumAdSoyad,Yorummail,Yorumicerik,Yemekid) values(@p1,@p2,@p3,@p4)", bgl);
			komut.Parameters.AddWithValue("@p1", TextBox1.Text);
			komut.Parameters.AddWithValue("@p2", TextBox2.Text);
			komut.Parameters.AddWithValue("@p3", TextBox3.Text);
			komut.Parameters.AddWithValue("@p4", SqlDbType.Int).Value = yemekid ?? (object)DBNull.Value;
			Response.Write("Başarılı Bir Şekilde yorum alınmıştır");
			komut.ExecuteNonQuery();
			bgl.Close();
		}
	}
}