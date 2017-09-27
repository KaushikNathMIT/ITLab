using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void PromotionCheck(object sender, EventArgs e)
    {
        EmpIdSelect();
        DateTime doj = DateTime.Parse(Text2.Value);
        if (DateTime.Now.Subtract(doj).Days > 1800)
            Promotion.Attributes["value"] = "Yes";
        else
            Promotion.Attributes["value"] = "No";

    }

    protected void EmpIdSelect()
    {
        String empId = Select1.Value + ".jpg";
        EmpImage.Attributes["src"] = ResolveUrl(empId);
    }
}