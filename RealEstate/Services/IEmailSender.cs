using System.Threading.Tasks;

namespace RealEstate.Services
{
	public interface IEmailSender
	{
		Task SendEmailAsync(string email, string subject, string message);
	}
}
