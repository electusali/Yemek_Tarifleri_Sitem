using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Services.Description;

namespace Yemek_Tarifleri_Sitem2
{
	public partial class TarifOner : System.Web.UI.Page
	{
		SqlConnection bgl = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Dbo_YemekTarifi;Integrated Security=True;");
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void TextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		protected void btnTarifOner_Click(object sender, EventArgs e)
		{
			Kontrol();
			SqlCommand komut =new SqlCommand("Insert into Tbl_Tarifler (TarihAd,TarihMalzeme,TarifYapilis,TarifResim,TarifSahip,TarifSahipMail) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl);
			komut.Parameters.AddWithValue("@p1", tbxTaifad.Text);
			komut.Parameters.AddWithValue("@p2", tbxMalzemeler.Text);
			komut.Parameters.AddWithValue("@p3", tbxYapilis.Text);
			komut.Parameters.AddWithValue("@p4", FileResim.FileName);
			komut.Parameters.AddWithValue("@p5", tbxTarifOner.Text);
			komut.Parameters.AddWithValue("@p6", tbxMailAdres.Text);
			komut.ExecuteNonQuery();
			bgl.Close();
			Response.Write("Tarif başarılı ile alınmıştır");

		}

		public void Kontrol()
		{
			if (bgl.State==ConnectionState.Closed)
			{
				bgl.Open();
			}
		}
	}
}