using System;
using LaporanKtmAPI.Model;
using LaporanKtmLibrary.Helper;
using Microsoft.AspNetCore.Mvc;

namespace LaporanKtmAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
    public class LaporanController : ControllerBase
	{
		private static List<Laporan> reportList = new List<Laporan>();
		public LaporanController()
		{
		}

		[HttpGet]
		public ActionResult<IEnumerable<Laporan>> Get()
		{
			try
			{
				return CollectionHelper.GetAll<Laporan>(reportList);
			} catch (Exception e)
			{
				return StatusCode(500, e.Message);
			}
		}

		[HttpGet("{id}")]
		public ActionResult<Laporan> Show(int id)
		{
			try
			{
				return CollectionHelper.GetById<Laporan>(reportList, id);
			} catch (Exception e)
			{
				return NotFound();
			}
		}

		[HttpPost]
		public ActionResult Save(Laporan laporan)
		{
			try
			{
                reportList = CollectionHelper.Add<Laporan>(reportList, laporan);
				return Ok();

            } catch (Exception e)
			{
				return StatusCode(500, e.Message);
			}
		}

		[HttpDelete("{id}")]
		public ActionResult Delete(int id)
		{
			try
			{
				CollectionHelper.Remove<Laporan>(reportList, id);
				return Ok();
			} catch (Exception e)
			{
				return StatusCode(500, e.Message);
			}
		}

		[HttpPut("{id}")]
		public ActionResult Update(int id, Laporan laporan)
		{
			try
			{
				reportList = CollectionHelper.Update(reportList, laporan, id);
				return Ok();
			} catch (Exception e)
			{
				if (e is ArgumentOutOfRangeException)
				{
					return NotFound();
				}

				return StatusCode(500, e.Message);
			}
		}
	}
}

