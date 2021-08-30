using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Yemek_Tarifleri_Sitem2
{
	public partial class iletisim : System.Web.UI.Page
	{
		SqlConnection bgl = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Dbo_YemekTarifi;Integrated Security=True;");
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnGonder_Click(object sender, EventArgs e)
		{
			Kontrol();
			SqlCommand komut =new SqlCommand("Insert into Tbl_Mesajlar (MesajGonderen,MesajBaslik,MesajMail,Mesajicerik) values(@p1,@p2,@p3,@p4)", bgl);
			komut.Parameters.AddWithValue("@p1", tbxGonderen.Text);
			komut.Parameters.AddWithValue("@p2",tbxBaslik.Text);
			komut.Parameters.AddWithValue("@p3",tbxMail.Text);
			komut.Parameters.AddWithValue("@p4", tbxMesaj.Text);
			Response.Write("Mesaj başarılı bir şelilde alınmıştır");
			komut.ExecuteNonQuery();
			bgl.Close();
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