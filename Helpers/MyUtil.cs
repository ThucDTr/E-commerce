using System.Text;

namespace Ecomerce.Helpers
{
	public class MyUtil
	{
		public static string UploadHinh(IFormFile Hinh, string folder)
		{
			try
			{
				var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Hinh", folder, Hinh.FileName);
				using(var myfile = new FileStream(fullPath, FileMode.CreateNew))
				{
					Hinh.CopyTo(myfile);
				}
				return Hinh.FileName;
			}
			catch (Exception ex)
			{
				return string.Empty;
			}
		}

		public static string GenerateRamdomKey(int lenght = 5)
		{
			var pattern = @"qazwsxedcrfvtgbyhnujmikolpQAZWSXEDCRFVTGBYHNUJMIKOLP";
			var sb = new StringBuilder();
			var rd = new Random();
			for(int i = 0; i < lenght; i++)
			{
				sb.Append(pattern[rd.Next(0, pattern.Length)]);
			}
			return sb.ToString();
		}
	}
}
