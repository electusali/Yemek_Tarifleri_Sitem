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
	public partial class AnaSayfa : System.Web.UI.Page
	{
		SqlConnection bgl = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Dbo_YemekTarifi;Integrated Security=True;");
		protected void Page_Load(object sender, EventArgs e)
		{
			Kontrol();
			SqlCommand komut=new SqlCommand("Select * From Tbl_Yemekler", bgl);
			SqlDataReader oku = komut.ExecuteReader();
			DataList2.DataSource = oku;
			DataList2.DataBind();
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