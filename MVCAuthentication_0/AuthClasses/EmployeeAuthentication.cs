using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAuthentication_0.AuthClasses
{
    /*
     AuthrozieAttribute gibi Attribute takısı ile biten sınıflar bir Controller'in veya Action'in üzerine attribute ile eklenme yapılmasını saglayan sınıflardır... Yani bu sınıftan miras alan sınıfınız artık bir Controller üzerine veya Action üzerine yazılıp daha onlar calısmadan işlem yapacaklardır...


    AuthorizeAttribute sınıfınız icerisinde virtual olarak tanımlanmıs AuthorizeCore isimli bir metot barındırır... Bu yapıyı Polymorphism kullanarak override ederseniz daha ilgili yapıya ulasmadan ne tarz bir kontrol yapacagınızı söyleyebilirsiniz...
     
     
     */
    public class EmployeeAuthentication:AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Session["emp"] != null )
            {
                return true;
            }

            httpContext.Response.Redirect("/Home/Login");
            return false;
        }
    }
}