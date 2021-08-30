using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace Yemek_Tarifleri_Sitem2
{
	public partial class GununYemegi : System.Web.UI.Page
	{
		SqlConnection bgl = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Dbo_YemekTarifi;Integrated Security=True;");
		protected void Page_Load(object sender, EventArgs e)
		{
			Kontrol();
			SqlCommand command = new SqlCommand();
			command.Connection = bgl;
			command.CommandText = ("Select * From Tbl_GununYemegi");
			SqlDataReader oku = command.ExecuteReader();
			DataList2.DataSource = oku;
			DataList2.DataBind();

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