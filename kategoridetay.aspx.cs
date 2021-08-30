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
	public partial class kategoridetay : System.Web.UI.Page
	{
		SqlConnection bgl = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Dbo_YemekTarifi;Integrated Security=True;");
		public string kategoriid = "";
		protected void Page_Load(object sender, EventArgs e)
		{
			Kontrol();
			kategoriid = Request.QueryString["Kategoriid"];
			SqlCommand command=new SqlCommand("Select * From Tbl_Yemekler where kategoriid=@p1 ", bgl);
			command.Parameters.AddWithValue("@p1", SqlDbType.Int).Value = kategoriid ?? (object)DBNull.Value;
			SqlDataReader reader = command.ExecuteReader();
			DataList2.DataSource = reader;
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