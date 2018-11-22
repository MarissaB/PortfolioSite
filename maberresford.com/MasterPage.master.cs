using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        bool colorbar = false;

        if (Request.Url.AbsolutePath.EndsWith("contact.aspx"))
        {
            linkcontact.Attributes["class"] = "active";
            colorbar = true;
        }

        if (Request.Url.AbsolutePath.EndsWith("resume.aspx"))
        {
            linkResume.Attributes["class"] = "active";
            colorbar = true;
        }

        if (Request.Url.AbsolutePath.EndsWith("portfolio.aspx"))
        {
            linkportfolio.Attributes["class"] = "active";
            colorbar = true;
        }

        if (Request.Url.AbsolutePath.EndsWith("tools.aspx"))
        {
            linktools.Attributes["class"] = "active";
            colorbar = true;
        }

        if (colorbar)
        {
            bodycontent.Style.Add("border-top", "solid 2px");
            bodycontent.Style.Add("border-top-color", "rgb(0, 122, 204)");
        }
    }
}
