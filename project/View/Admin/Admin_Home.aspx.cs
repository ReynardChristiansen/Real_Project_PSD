﻿using project.Controller;
using project.Handler;
using project.Model;
using project.Repositoy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project.View.Admin
{
    public partial class Admin_Home : System.Web.UI.Page
    {
        public List<Artist> Artists = new List<Artist>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Artists = ArtistRepository.GetArtists();
            Admin_GridView.DataSource = Artists;
            Admin_GridView.DataBind();
        }

        protected void insrt_artist_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Admin/Admin_InsertArtist.aspx");
        }

        protected void Admin_GridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = Admin_GridView.Rows[e.RowIndex];
            string id = row.Cells[0].Text.ToString();
            int temp = Convert.ToInt32(id);
            
            Handler_Public.delete_Artist_Album(temp);
            
            Response.Redirect("~/View/Admin/Admin_Home.aspx");
        }

        protected void Admin_GridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = Admin_GridView.Rows[e.NewEditIndex];
            string id = row.Cells[0].Text.ToString();
            Response.Redirect("~/View/Admin/Admin_UpdateArtist.aspx?ID="+id);
        }

        protected void Admin_GridView_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = Admin_GridView.Rows[e.NewSelectedIndex];
            string id = row.Cells[0].Text.ToString();
            Response.Redirect("~/View/Admin/Admin_ArtistDetail.aspx?ID=" + id);
        }
    }
}