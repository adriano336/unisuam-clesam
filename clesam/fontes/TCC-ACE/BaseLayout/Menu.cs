using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC_ACE.Menu
{
    public class Menu
    {

        public static string MenuList(Recurso recurso)
        {

            string html = "";

            html += "<li>";

            html += "<a href='#' class='dropdown-toggle'>";
            if (recurso.src != null)
            {
                html += "<i class='" + recurso.src + "'></i>";
            }
            html += "<span class='menu-text'>"+recurso.titulo+"</span>";

            if (recurso.Recurso1.Count() != 0)
            {
                html += "<b class='arrow icon-angle-down'></b>";
            }
            

            html += "</a>";
            if (recurso.Recurso1.Count() != 0)
            {
                html += "<ul class='submenu'>";
                foreach (Recurso r in recurso.Recurso1)
                {
                    html += MenuList(r);
                }
                html += "</ul>";

            }

            html += "</li>";

            return html;

        }

        public static string MenuLateral()
        {

            ContextEntities context = new ContextEntities();
            var recursos = context.Recurso.Where(s => s.TipoRecurso.codigo == 1);

            string html = "";

            foreach (Recurso r in recursos)
            {
                html += MenuList(r);
            }

            return html;
        }

    }
}