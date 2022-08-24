using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Pacote
/// </summary>
public class Pacote
{
    public object obj;
    //Exclusivo para comunicação do back-end com o front para uma c
    public bool status = false;
    public string msg = "";

    //Para auditoria dos métodos onde não comprometa o fluxo!
    public string err_msg = "";
    public bool err_status = false;

    public string dt_transacao = DateTime.Now.ToString("yyyy-MM-dd");
}