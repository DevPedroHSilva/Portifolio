using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
public partial class CS_Contatos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [WebMethod]
    public static Pacote testandoComunicacao(string teste)
    {
        Pacote p = new Pacote();
        p.msg = teste;
        return p;
    }
    
}