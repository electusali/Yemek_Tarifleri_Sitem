using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System .Data.SqlClient;
using System.Data;
using System.Runtime.CompilerServices;

namespace Yemek_Tarifleri_Sitem2
{
	public partial class Hakkimizda : System.Web.UI.Page
	{
		SqlConnection bgl = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Dbo_YemekTarifi;Integrated Security=True;");
		protected void Page_Load(object sender, EventArgs e)
		{
			Kontrol();
			SqlCommand command=new SqlCommand("Select * From Tbl_Hakkimizda", bgl);
			SqlDataReader reader = command.ExecuteReader();
			DataList2.DataSource = reader;
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