using AnoraRFID.DataAccess;
using AnoraRFID.DataAccess.DAL;
using AnoraRFID.DataAccess.DAL.Entities;
using AnoraRFID.DataAccess.Models;
using AnoraRFID.DataAccess.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using static AnoraRFID.DataAccess.DAL.Entities.LogEntity;

namespace AnoraRFID.WebApi.Controllers.Logs
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogsController : ApiControllerBase
    {
        public LogsController(AppDbContext context) : base(context)
        {

        }

        [HttpGet()]
        public ResponseModel Get(string keyWord = "", int level = 0
            , string fromDate = "", string toDate = ""
            , int pageItem = 10, int pageIndex = 0)
        {
            var dFromDate = fromDate.ToDateTime().Date;
            var dToDate = toDate.ToDateTime().Date;

            var result = _context.LOG
                .Where(x => (x.Level == (LogLevel)level || level == 0)
                            && (string.IsNullOrWhiteSpace(keyWord) 
                                || x.RequestIpAddress.Contains(keyWord)
                                || x.RequestUrl.Contains(keyWord))
                            && (string.IsNullOrEmpty(fromDate) || x.CREATED_DATE.Date >= dFromDate)
                            && (string.IsNullOrEmpty(toDate) || x.CREATED_DATE.Date <= dToDate))
                .OrderByDescending(x => x.CREATED_DATE)
                .AsNoTracking();

            return rspns.Succeed(new PaginationResponse<LogEntity>(result, pageItem, pageIndex));
        }
    }
}
