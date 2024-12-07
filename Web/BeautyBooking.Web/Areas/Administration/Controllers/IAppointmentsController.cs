using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BeautyBooking.Web.Areas.Administration.Controllers
{
    public interface IAppointmentsController
    {
        Task<IActionResult> Index();
    }
}