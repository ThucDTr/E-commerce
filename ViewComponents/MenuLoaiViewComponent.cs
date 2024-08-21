using Ecomerce.Data;
using Ecomerce.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Ecomerce.ViewComponents
{
    public class MenuLoaiViewComponent : ViewComponent
    {
        private readonly EcommerceContext db;

        public MenuLoaiViewComponent(EcommerceContext context) => db = context;

        public IViewComponentResult Invoke()
        {
            var data = db.Loais.Select(lo => new MenuVM
            {
                MaLoai = lo.MaLoai,
                TenLoai = lo.TenLoai,
                SoLuong = lo.HangHoas.Count
            }).OrderBy(p => p.TenLoai);
            return View(data);
        }
    }
}
