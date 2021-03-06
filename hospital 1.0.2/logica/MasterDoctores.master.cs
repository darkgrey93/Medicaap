﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using utilitarios;
using Logica;

public partial class MasterDoctores : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LUsuarios log = new LUsuarios();
        UUsuario datos = new UUsuario();
        String rol = Session["rol_user"] as String;
        String nombre = Session["user"] as String;
        Object nomb = Session["objdata"] as Object;

        UUsuario user = (UUsuario)Session["objdata"];

        /*esto es para validar la session del usuario*/
        log.session(int.Parse(Session["id_user"].ToString()));

        Im_Perfil.ImageUrl = user.DireccionImagen;
        Response.Cache.SetNoStore();
    }
    protected void B_salir_Click(object sender, EventArgs e)
    {
        Session["id_user"] = null;
        Session["user"] = null;
        Session["rol_user"] = null;
        Response.Redirect("Login.aspx");

        Response.Cache.SetNoStore();
    }
}
